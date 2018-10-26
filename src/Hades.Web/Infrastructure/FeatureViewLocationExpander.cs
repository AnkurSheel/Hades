using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.Razor;

namespace Hades.Web.Infrastructure
{
	public class FeatureViewLocationExpander : IViewLocationExpander
	{
		public void PopulateValues(ViewLocationExpanderContext context)
		{
		}

		public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}

			if (viewLocations == null)
			{
				throw new ArgumentNullException(nameof(viewLocations));
			}

			// {0} - Action Name
			// {1} - Controller Name
			// {2} - Area Name
			// Replace normal view location entirely
			yield return "/Features/{1}/{0}.cshtml";
			yield return "/Features/Shared/{0}.cshtml";
		}
	}
}
