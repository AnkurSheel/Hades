using System;

using Hades.Web.Infrastructure;

using Microsoft.Extensions.DependencyInjection;

namespace Hades.Web
{
	public static class ServiceCollectionExtensions
	{
		public static IMvcBuilder AddFeatureFolders(this IMvcBuilder services)
		{
			if (services == null)
			{
				throw new ArgumentNullException(nameof(services));
			}

			services.AddRazorOptions(options =>
									 {
										 options.ViewLocationExpanders.Add(new FeatureViewLocationExpander());
									 });
			return services;
		}
	}
}
