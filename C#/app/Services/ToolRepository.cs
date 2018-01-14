using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.Services
{
    public class ToolRepository
    {
        private Tool[] tools;

        public ToolRepository()
        {
            var tools = new Tool[]
            {
                new Tool
                {
                    Id = 1, Name = "Bügelmessschraube"
                },
                new Tool
                {
                    Id = 2, Name = "Messschieber"
                }
            };
            this.tools = tools;
        }
        public Tool[] GetAllTools()
        {
            if (this.tools != null)
            {
                return this.tools;
            }

            return new Tool[]
            {
                new Tool
                {
                    Id = 0,
                    Name = "Placeholder"
                }
            };
        }
        //public Tool[] GetAllTools()
        //{
        //    if (this.tools != null)
        //    {
        //        return this.tools;
        //    }

        //    return new Tool[]
        //    {
        //        new Tool
        //        {
        //            Id = 0,
        //            Name = "Placeholder"
        //        }
        //    };
        //}
        //private const string CacheKey = "ToolStore";

        //public bool SaveTool(Tool tool)
        //{
        //    var ctx = HttpContext.Current;

        //    if (ctx != null)
        //    {
        //        try
        //        {
        //            var currentData = ((Tool[])ctx.Cache[CacheKey]).ToList();
        //            currentData.Add(tool);
        //            ctx.Cache[CacheKey] = currentData.ToArray();

        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.ToString());
        //            return false;
        //        }
        //    }

        //    return false;
        //}
    }
}