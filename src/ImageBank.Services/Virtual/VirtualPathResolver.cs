﻿using System.Web;

namespace ImageBank.Services.Virtual
{
    public class VirtualPathResolver : IVirtualPathResolver
    {
        public string ResolvePath(string virtualPath)
        {
            return HttpContext.Current.Server.MapPath(virtualPath);
        }
    }
}