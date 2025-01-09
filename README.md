# Hub Plugin for PowerToys Run

This is a PowerToys Run plugin that provides a versatile set of tools directly accessible via the PowerToys Run search interface. It allows users to quickly translate words or sentences, search for information in Google Scholar, use ChatGPT, or search the web via DuckDuckGo.

## Features

- **Translate**: Translate text using Tureng, or sentences using DeepL.
- **Search in Google Scholar**: Quickly search academic articles in Google Scholar.
- **Search in ChatGPT**: Directly search ChatGPT for answers or information.
- **Search in DuckDuckGo**: Perform a web search using DuckDuckGo.

##  Notice

- I did this to help me in my daily life- this is why it only supports Turkish-English/English-Turkish translate-, so it is not functional that much, and quite amateur.
- You can perform web search only by using DuckDuckGo for now.
- It requires no API because It basically opens them at your default explorer.
- I am sharing this to help people like me.

### Screenshots

![ss1](/Screenshots/ss1.png)

Tureng:
![ss2](/Screenshots/ss2.png)

DeepL:
![ss3](/Screenshots/ss3.png)

Scholar:
![ss4](/Screenshots/ss4.png)

ChatGPT:
![ss5](/Screenshots/ss5.png)

DuckDuckGo:
![ss6](/Screenshots/ss6.png)


### Available Commands

- `tr <text>`: Translate text or sentence.
- `ara <text>`: Search for the given text in Google Scholar.
- `gpt <text>`: Search for the given text in ChatGPT.
- `dd <text>`: Perform a web search with DuckDuckGo.

### Usage

1. **Install PowerToys**: If you haven't already, download and install [PowerToys](https://github.com/microsoft/PowerToys).
2. **Install the Hub Plugin**: 
   - Download the plugin `.dll` file and place it in the appropriate PowerToys plugin folder.
   - Ensure that you enable the plugin in the PowerToys Run settings.
3. **Using the Plugin**:
   - Press `Alt + Space` to open PowerToys Run.
   - Type `i` (or another configured keyword) and start typing your desired command. For example:
     - Type `tr Hello` to translate the word "Hello".
     - Type `ara Machine Learning` to search for articles on Google Scholar.

### Commands and Examples

| Command              | Example            | Description                                                 |
| -------------------- | ------------------ | ----------------------------------------------------------- |
| `tr <text>`           | `tr Hello`         | Translate the text "Hello"                                  |
| `ara <text>`          | `ara Quantum Physics` | Search for "Quantum Physics" in Google Scholar                |
| `gpt <text>`          | `gpt Artificial Intelligence` | Search for "Artificial Intelligence" in ChatGPT               |
| `dd <text>`           | `dd Computer Science` | Search for "Computer Science" on DuckDuckGo                   |

### Plugin Configuration

- **Action Keyword**: You can invoke this plugin by typing `i` in PowerToys Run search bar. The default action keyword is configured in `plugin.json` (`"ActionKeyword": "i"`), or in Settings on Powertoys Run.
- **Icons**: The plugin uses a default icon for search results. You can customize the icons by replacing the images in the `Images/` folder.

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/isotjs/PowerToys-Run-Hub.git
    ```

2. Build the project in Visual Studio or use .NET CLI:
   ```bash
    dotnet build
   ```

    Copy the resulting .dll file to the PowerToys Run plugin directory.

    Enable the plugin from the PowerToys Run settings.

### License

This project is licensed under the MIT License - see the LICENSE file for details.

### Author

    isot.jpeg
    
