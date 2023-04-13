return await Bootstrapper
  .Factory
  .CreateWeb(args)
  .DeployToGitHubPages(
        "SonicHubTW",
        "sonichubtw.github.io",
        Config.FromSetting<string>("GITHUB_TOKEN")
    )
  .RunAsync();