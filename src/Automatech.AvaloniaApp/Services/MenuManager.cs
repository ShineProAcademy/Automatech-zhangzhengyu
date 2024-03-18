using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using Automatech.AvaloniaApp.Models;

namespace Automatech.AvaloniaApp.Services;

public class MenuManager
{
    private static readonly string _menuConfig = Path.Combine(Assembly.GetEntryAssembly().Location, "MenuConfig.json");
    private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions();

    static MenuManager()
    {
        _jsonSerializerOptions.WriteIndented = true;
    }
    
    public static IList<TreeNode> Load()
    {
        IList<TreeNode> nodes = null;
        
        try
        {
            using (FileStream stream = new FileStream(_menuConfig, FileMode.Open, FileAccess.Read))
            {
                nodes = JsonSerializer.Deserialize<IList<TreeNode>>(stream, _jsonSerializerOptions);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"MenuConfig.json文件加载异常。\n{e.Message}\n{e.StackTrace}");
        }
        
        return nodes;
    }

    public static void Save(IList<TreeNode> nodes)
    {
        if (nodes == null)
        {
            return;
        }

        if (nodes.Count == 0)
        {
            return;
        }

        try
        {
            byte[] buffer = JsonSerializer.SerializeToUtf8Bytes<IList<TreeNode>>(nodes, _jsonSerializerOptions);
            using (FileStream stream = new FileStream(_menuConfig, FileMode.Create, FileAccess.Write))
            {
                stream.Write(buffer);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"MenuConfig.json文件保存异常。\n{e.Message}\n{e.StackTrace}");
        }
    }
} 