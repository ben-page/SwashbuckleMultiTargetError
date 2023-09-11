namespace SwashbuckleMultiTargetError
{
    public static class SwashbuckleSingleTarget
    {
        public static WebApplication ConfigureForDevelopment(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            return app;
        }
    }
}
