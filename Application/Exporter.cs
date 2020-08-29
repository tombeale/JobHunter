using BlueSite.Data;
using BlueSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JobHunter.Application
{
    public class Exporter
    {
        BlueSiteContext _context { get; set; }

        JobHuntRepository Repository;

        public Exporter(BlueSiteContext context)
        {
            _context = context;
            Repository = new JobHuntRepository(_context);
        }

        public string ExportTech(string path)
        {
            string result = "";
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                var UsedKeys = Repository.GetUsedLanguageTagList;
                var Technologies = Repository.GetLanguages.OrderBy(f => f.BaseYear).ToList();
                string Data = JsonSerializer.Serialize(Technologies, options);
                File.WriteAllText($@"{path}\Techologies.json", Data);

                var Technmap = Repository.GetLanguageMap.Where(k => UsedKeys.Contains(k.Tag)).ToList();
                Data = $"var techMapData = {JsonSerializer.Serialize(Technmap, options)};";
                File.WriteAllText($@"{path}\TechMap.js", Data);
            }
            catch (Exception e)
            {
                result = e.ToString();
            }
            return result;
        }
        public string ExportTechMap(string path)
        {
            string result = "";
            try
            {
                var UsedKeys = Repository.GetUsedLanguageTagList;
                var Technologies = Repository.GetLanguageMap.Where(k => UsedKeys.Contains(k.Tag)).ToList();

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string Data = JsonSerializer.Serialize(Technologies, options);
                File.WriteAllText(path, Data);
            }
            catch (Exception e)
            {
                result = e.ToString();
            }

            return result;
        }
    }
}
