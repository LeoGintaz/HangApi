using HangApi.Models;

namespace HangApi.Database.InitialData
{
    public static class WordsInitialData
    {
        public static readonly Words[] DataSeed = 
            {
            new Words
            { 
            Id = 1,
            Theme = "animals",
            WordOne = "panther",
            WordTwo = "giraffe",
            WordThree = "frog",
            WordFour = "hipopotomus",
            WordFive = "zebra"
            },
             new Words
            {
            Id = 2,
            Theme = "lithuanian cities",
            WordOne = "kaunas",
            WordTwo = "vilnius",
            WordThree = "siauliai",
            WordFour = "panevezys",
            WordFive = "klaipeda"
            }


            };
    }
}
