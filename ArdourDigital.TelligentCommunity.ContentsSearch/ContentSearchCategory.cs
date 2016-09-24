using Telligent.Evolution.Extensibility.Api.Entities.Version1;
using Telligent.Evolution.Extensibility.Content.Version1;
using Telligent.Evolution.Extensibility.Version1;

namespace ArdourDigital.TelligentCommunity.ContentsSearch
{
    public class ContentSearchCategory : ISearchCategories, ITranslatablePlugin, IPlugin
    {
        private ITranslatablePluginController _translationController;

        public void Initialize()
        {
        }

        public string Name
        {
            get
            {
                return "Ardour Digital - Fix Content Pages Search";
            }
        }

        public string Description
        {
            get
            {
                return "Fixes a bug in Telligent 7.x -> 9.x where selecting content facet does not work correctly.";
            }
        }

        public Translation[] DefaultTranslations
        {
            get
            {
                var contentTranslation = new Translation("en-US");
                contentTranslation.Set("content", "Content");

                return new[]
                {
                    contentTranslation
                };
            }
        }

        public SearchCategory[] GetCategories()
        {
            return new[]
            {
                new SearchCategory("content", _translationController.GetLanguageResourceValue("content"))
            };
        }

        public void SetController(ITranslatablePluginController controller)
        {
            _translationController = controller;
        }
    }
}
