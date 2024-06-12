using Lesson1.Models;

namespace Lesson1.Services;

public class LanguageServiceImpl : LanguageService
{
    private List<Language> languages;

    public LanguageServiceImpl()
    {
        languages = new List<Language>()
        {
            new Language() {
                Id = 1,
                Name = "Language 1"
            },
            new Language() {
                Id = 2,
                Name = "Language 2"
            },
            new Language() {
                Id = 3,
                Name = "Language 3"
            },
            new Language() {
                Id = 4,
                Name = "Language 4"
            },
            new Language() {
                Id = 5,
                Name = "Language 5"
            },
            new Language() {
                Id = 6,
                Name = "Language 6"
            }
        };


    }

    public List<Language> findAll()
    {
        return languages;
    }
}
