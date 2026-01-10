using System.Text.Json;

namespace LibraryDatabase;

public class AppConfig
{
    public string ConnectionString { get; set; }
}

/// <summary>
/// Class for loading JSON config file
/// </summary>
public static class ConfigLoader
{
    /// <summary>
    /// Loads connection string from the JSON file
    /// </summary>
    /// <returns>Connection string</returns>
    public static AppConfig Load()
    {
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"appsettings.json");

        if (!File.Exists(path))
        {
            MessageBox.Show("Configuration file appsettings.json not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            Environment.Exit(1);
        }
        
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<AppConfig>(json);
    }
}