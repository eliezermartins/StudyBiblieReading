namespace StudyBibleReading.Domain.Models;

public class ReadingPlanDay
{
    public ReadingPlanDay(ReadingPlan plan, int id, DateOnly date/*, List<Chapter>? chapters*/)
    {
        Id = id;
        ReadingPlan = plan;
        ReadingPlanId = plan.Id;
        Date = date;

        //Chapters = chapters ?? new List<Chapter>();
    }

    protected ReadingPlanDay()
    {
    }

    public int Id { get; set; }

    public Guid ReadingPlanId { get; set; }

    public ReadingPlan ReadingPlan { get; set; } = null!;

    public DateOnly Date { get; set; }

    public string Description { get; set; } = string.Empty;

    public bool IsRead { get; set; }

    //public ICollection<Chapter> Chapters { get; set; } = null!;

    //public bool IsRead => Chapters.All(c => c.IsRead);

    //public string Reading
    //{
    //    get
    //    {
    //        var firstChapter = Chapters.FirstOrDefault();
    //        var lastChapter = Chapters.Count > 1 ? Chapters.LastOrDefault() : null;

    //        if (firstChapter is null)
    //        {
    //            return string.Empty;
    //        }

    //        var reading = $"{firstChapter.Book.Abbreviation}. {firstChapter.Id}";

    //        if (lastChapter is null)
    //        {
    //            return reading;
    //        }

    //        if (firstChapter.BookId != lastChapter.BookId)
    //        {
    //            return reading + $" - {lastChapter.Book.Abbreviation}. {lastChapter.Id}";
    //        }

    //        return reading + $" - {lastChapter.Id}";
    //    }
    //}

    //public void AddChapter(Chapter chapter)
    //{
    //    var bible = Chapters.Select(l => l.Book).Select(l => l.Bible).First();
    //    if (bible.Id != chapter.BibleId)
    //    {
    //        throw new ApplicationException("Biblias diferentes");
    //    }

    //    Chapters.Add(chapter);
    //}
}
