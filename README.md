# Unity-Singleton-Pattern-Generic
A reusable, generic Singleton pattern for Unity using MonoBehaviour and pure C# class support.
No more rewriting the singleton logic in every script — just inherit and go!
### ⚡How To Use:
- Download the script and import it into your Unity project.

For MonoBehaviour classes:

Inherit your class from Singleton<T>, like this:

> public class GameManager : `Singleton<GameManager>` { }

Then call it easily from anywhere:

> GameManager.Instance.DoSomething();

Make Sure to Call Awake:

> protected override void Awake()
> {
>    base.Awake();
>    // Other Codes
> }

To persist the instance across scenes, override ShouldPersist:

> protected override bool ShouldPersist => true;

For pure C# (non-MonoBehaviour) singletons:
Use PureSingleton<T>, like this:

> public class ConfigManager : `PureSingleton<ConfigManager>` { }


Just a guy making games.
Exploring the world of game development with Unity tutorials, coding tips, and shader magic, and fixing bugs.
game-related, sometimes not.

🔥follow my YouTube @GameDevBox to find more Tutorials and Tips: [GameDevBox](https://www.youtube.com/@GameDevBox)

🔥See the tutorial for how you can set it up: https://youtu.be/Z2M0USjzSDw

## Social Media: 
• [X/Twitter](https://x.com/ArianKhatiban)
• [Instagram](https://www.instagram.com/arian.khatiban):
• [LinkedIn](https://www.linkedin.com/in/arian-khatiban-49b30017a/):
• [Discord Server](https://discord.gg/8hpGqBgXmz):
• [itch.io](https://cloudtears.itch.io/):
• [Youtube Subscribe](https://www.youtube.com/channel/UCgXs2PTiL19Rv1qOn1SI7XQ?sub_confirmation=1):
