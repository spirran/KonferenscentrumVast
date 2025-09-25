using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class ContractDoucument : IDocument
{
    public void Compose(IDocumentContainer container)
    {
        container.
        Page( page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(2, Unit.Centimetre);
            page.PageColor(Colors.White);
            page.DefaultTextStyle(x => x.FontSize(20));

            page.Header()
                .Text("Konferenscentrum Väst - Booking Contract")
                .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

            page.Content()
                .PaddingVertical(1, Unit.Centimetre)
                .Column(column =>
                {
                    column.Item().Text()
                })
        })
    }
}