# Bytewarden

This is an unofficial fork of the bitwarden mobile application that is targeting older Windows UWP platforms including Windows 10 and Windows Phone 10. This is forked from the official bitwarden application (https://github.com/bitwarden/mobile).

This is not affiliated with bitwarden or bitwarden Inc.

The app is avaliable on Windows 10, Windows 10 S, Windows 10 Mobile and the Xbox One via the [Microsoft Store - Bytewarden](https://www.microsoft.com/en-us/store/p/bytewarden/9n248v7dk05k)

**Requirements**

- [Visual Studio w/ Xamarin -or- Xamarin Studio](https://store.xamarin.com/)

By default the app is targeting the production API. If you are running the [Core](https://github.com/bitwarden/core) API locally,
you'll need to switch the app to target your local instance. Open `src/App/Utilities/ApiHttpClient.cs` and `src/App/Utilities/IdentityHttpClient.cs` and set the `BaseAddress` to your local
API endpoints (ex. `new Uri("http://localhost:5000")`). Alternatively, you can also adjust the environment endpoints from the environment settings page on the home screen of the app (log out).

After restoring the nuget packages, you can now build and run the app.

# Contribute

Code contributions are welcome! Visual Studio or Xamarin Studio is required to work on this project. Please commit any pull requests against the `master` branch.
Learn more about how to contribute by reading the [`CONTRIBUTING.md`](CONTRIBUTING.md) file.

Security audits and feedback are welcome. Please open an issue or email us privately if the report is sensitive in nature. You can read our security policy in the [`SECURITY.md`](SECURITY.md) file.
