using KonferenscentrumVast.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class ContractDoucument : IDocument
{
    private readonly BookingContract _contract;

    public ContractDoucument(BookingContract contract)
    {
        _contract = contract;
    }
    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(2, Unit.Centimetre);
            page.PageColor(Colors.White);
            page.DefaultTextStyle(x => x.FontSize(12));

            page.Header()
                .Text("Konferenscentrum Väst - Booking Contract")
                .SemiBold()
                .FontSize(24)
                .FontColor(Colors.Blue.Medium);

            page.Content()
                .PaddingVertical(1, Unit.Centimetre)
                .Column(column =>
                {
                    column.Spacing(5);

                    column.Item().Text($"Contract Number: {_contract.ContractNumber}");
                    column.Item().Text($"Version: {_contract.Version}");
                    column.Item().Text($"Status: {_contract.Status}");
                    column.Item().Text($"Created: {_contract.CreatedDate:yyyy-MM-dd}");
                    column.Item().Text($"Customer: {_contract.CustomerName} ({_contract.CustomerEmail})");
                    column.Item().Text($"Facility: {_contract.FacilityName}");
                    column.Item().Text($"Total Amount: {_contract.TotalAmount} {_contract.Currency}");
                    column.Item().Text($"Payment Due: {_contract.PaymentDueDate:yyyy-MM-dd}");

                    if (!string.IsNullOrWhiteSpace(_contract.Terms))
                        column.Item().Text($"Terms:\n{_contract.Terms}");
                });
        });
    }
}