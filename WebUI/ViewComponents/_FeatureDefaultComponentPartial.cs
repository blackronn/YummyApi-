﻿using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class _FeatureDefaultComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
    }
