# Releasing the Google.Events packages

This assumes all due diligence has already been done, and the
version number has been chosen following [Semantic
Versioning](https://semver.org).

1. Update the version number in the [common MSBuild XML file](src/ProductionProperties.xml).

2. Commit the change with a commit message like this (for version xyz, with preceding version abc):

   > Release Google.Events packages version xyz
   >
   > Changes since abc:
   > - ...
   >
   > Packages in this release:
   > - Release Google.Events version xyz
   > - Release Google.Events.Protobuf version xyz
   
   Notes:
   - The title must *not* match "Release {single-word} version {version}"
     (otherwise `releasetool` will try to create a package with that single word)   
   - The list of packages must be in *exactly* that format (so that `releasetool` knows what to tag/release)

3. Push the commit to GitHub, create a PR and add the label "autorelease: pending"

Once the PR is merged, automation takes over:

- `releasetool` will create a tag and release on GitHub, and trigger a Kokoro job
- The Kokoro job will build, test and push to NuGet
