using System.Globalization;

namespace DotNetTrainingBatch2.MvcApp.Middlwares
{
    public class CookieMiddleware
    {
        private readonly RequestDelegate _next;

        public CookieMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path == "/") goto result;

            var auth = context.Request.Cookies["Auth"];
            if (string.IsNullOrWhiteSpace(auth))
            {
                context.Response.Redirect("/");
                return;
            }

            result:
            // Call the next delegate/middleware in the pipeline.
            await _next(context);
        }
    }

    //public static class CookieMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseCookieMiddleware(
    //        this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<CookieMiddleware>();
    //    }
    //}

    public static class CookieMiddlewareExtensions
    {
        public static IApplicationBuilder UseCookieMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CookieMiddleware>();
        }
    }
    //CookieMiddlewareExtensions.AddCookieMiddleware(app);
    //app.AddCookieMiddleware();
}
