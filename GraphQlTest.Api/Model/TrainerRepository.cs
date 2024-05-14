namespace GraphQlTest.Api.Model;

public class TrainerRepository
{
    private static List<Trainer> TrainerInternal { get; set; } =
    [
        new Trainer
        {
            Name = "Ash",
            NrOfBadges = 8
        },
        new Trainer
        {
            Name = "Gary",
            NrOfBadges = 7
        }
    ];

    public static IQueryable<Trainer> Trainer => TrainerInternal.AsQueryable();

    public static void AddTrainer(Trainer trainer)
    {
        TrainerInternal.Add(trainer);
    }
}