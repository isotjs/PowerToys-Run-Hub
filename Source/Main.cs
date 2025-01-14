using System.Diagnostics;
using System.Net.Http;
using System.Windows.Controls;
using Wox.Plugin;

namespace Community.PowerToys.Run.Plugin.hub
{
    public class Main : IPlugin
    {
        private PluginInitContext? _context;
        private static readonly HttpClient client = new HttpClient();

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public string Name => "Hub";
        public string Description => "Use Hub to translate, to use duckduckgo, to use gpt, or to research in scholar.";
        public static string PluginID => "1d69da9c-1a82-4097-913c-954472e51f28";

        public List<Result> Query(Query query)
        {
            var results = new List<Result>();

            if (string.IsNullOrWhiteSpace(query.Search))
            {
                results.Add(new Result
                {
                    Title = "Translate",
                    SubTitle = "Use 'tr' to translate text or sentence",
                    IcoPath = "Images\\Translate.dark.png",
                    Action = e =>
                    {
                        _context?.API.ChangeQuery($"{query.RawQuery} tr ");
                        return false; 
                    }
                });
                results.Add(new Result
                {
                    Title = "Search in Google Scholar",
                    SubTitle = "Use 'ara' to search in Google Scholar",
                    IcoPath = "Images\\Scholar.dark.png",
                    Action = e =>
                    {
                        _context?.API.ChangeQuery($"{query.RawQuery} ara ");
                        return false; 
                    }
                });
                results.Add(new Result
                {
                    Title = "Search in ChatGPT",
                    SubTitle = "Use 'gpt' to search in ChatGPT",
                    IcoPath = "Images\\GPT.dark.png",
                    Action = e =>
                    {
                        _context?.API.ChangeQuery($"{query.RawQuery} gpt ");
                        return false;
                    }
                });
                results.Add(new Result
                {
                    Title = "Search in DuckDuckGo",
                    SubTitle = "Use 'dd' to search in DuckDuckGo",
                    IcoPath = "Images\\DDG.dark.png",
                    Action = e =>
                    {
                        _context?.API.ChangeQuery($"{query.RawQuery} dd ");
                        return false;
                    }
                });
            }
            else if (query.Search.Length > 0)
            {
                var input = query.Search.Trim();
                var parts = input.Split(new[] { ' ' }, 2);

                if (parts.Length > 1)
                {
                    var command = parts[0].ToLower();
                    var argument = parts[1];

                    if (command == "tr")
                    {
                        var wordCount = argument.Split(' ').Length;

                        if (wordCount > 2)
                        {
                            var url = $"https://www.deepl.com/en/translator#en/tr/{argument}";
                            results.Add(new Result
                            {
                                Title = $"Translate Sentence: {argument}",
                                SubTitle = $"Translate '{argument}' using DeepL",
                                IcoPath = "Images\\Translate.dark.png",
                                Action = e =>
                                {
                                    Process.Start(new ProcessStartInfo
                                    {
                                        FileName = url,
                                        UseShellExecute = true
                                    });
                                    return true;
                                }
                            });
                        }
                        else
                        {
                            results.Add(new Result
                            {
                                Title = $"Translate: {argument}",
                                SubTitle = $"Translate '{argument}' Tureng",
                                IcoPath = "Images\\Tureng.dark.png",
                                Action = e =>
                                {
                                    Process.Start(new ProcessStartInfo
                                    {
                                        FileName = $"https://tureng.com/en/turkish-english/{argument}",
                                        UseShellExecute = true
                                    });
                                    return true;
                                }
                            });
                        }
                    }
                    else if (command == "ara")
                    {
                        results.Add(new Result
                        {
                            Title = $"Search in Google Scholar: {argument}",
                            SubTitle = $"Search '{argument}' in Google Scholar",
                            IcoPath = "Images\\Scholar.dark.png",
                            Action = e =>
                            {
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = $"https://scholar.google.com/scholar?hl=tr&as_sdt=0%2C5&q={argument}",
                                    UseShellExecute = true
                                });
                                return true;
                            }
                        });
                    }
                    else if (command == "gpt")
                    {
                        results.Add(new Result
                        {
                            Title = $"Search in ChatGPT: {argument}",
                            SubTitle = $"Search '{argument}' in ChatGPT",
                            IcoPath = "Images\\GPT.dark.png",
                            Action = e =>
                            {
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = $"https://chatgpt.com/?q={argument}",
                                    UseShellExecute = true
                                });
                                return true;
                            }
                        });
                    }
                    else if (command == "dd")
                    {
                        results.Add(new Result
                        {
                            Title = $"Search in DuckDuckGo: {argument}",
                            SubTitle = $"Search '{argument}' in DuckDuckGo",
                            IcoPath = "Images\\DDG.dark.png",
                            Action = e =>
                            {
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = $"https://duckduckgo.com/{argument}",
                                    UseShellExecute = true
                                });
                                return true;
                            }
                        });
                    }
                }
            }

            return results;
        }

        public string UpdateInfo => "No updates available.";

        public Control CreateSettingPanel()
        {
            return new Control();
        }
    }
}
