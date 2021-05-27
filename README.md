<h1 id="Basics-Of-Software-Development-On-.Net" align="center">
  Basics-Of-Software-Development-On-.Net <img alt="logo" width="40" height="40" src="https://raw.githubusercontent.com/mezgoodle/images/master/MezidiaLogoTransparent.png" /><br>
  <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/mezidia/Basics-Of-Software-Development-On-.Net.svg?style=flat-square&logo=github&logoColor=white">
  <img alt="language" src="https://img.shields.io/badge/language-CSharp-blueviolet?style=flat-square" />
  <img alt="issues" src="https://img.shields.io/github/issues/mezidia/Basics-Of-Software-Development-On-.Net?style=flat-square" />
  <img alt="GitHub closed issues" src="https://img.shields.io/github/issues-closed/mezidia/Basics-Of-Software-Development-On-.Net?style=flat-square" />
  <img alt="GitHub pull requests" src="https://img.shields.io/github/issues-pr/mezidia/Basics-Of-Software-Development-On-.Net?style=flat-square" />
  <img alt="GitHub closed pull requests" src="https://img.shields.io/github/issues-pr-closed/mezidia/Basics-Of-Software-Development-On-.Net?style=flat-square" />
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/mezidia/Basics-Of-Software-Development-On-.Net?style=flat-square" />
  <img alt="Latest Github release" src="https://img.shields.io/github/release/mezidia/Basics-Of-Software-Development-On-.Net?style=flat-square" />
  <img alt="Theme" src="https://img.shields.io/badge/Theme-Study-brightgreen?style=flat-square" />
</h1>

<p align="center">
 🌟Hello everyone! This is the repository of Our labs on CSharp.🌟
</p>

<h2 align="center">
  <i>Table of contents</i>
</h2>

- [Basics-Of-Software-Development-On-.Net](#Basics-Of-Software-Development-On-.Net)
- [Tech/framework used :wrench:](#techframework-used-wrench)
- [Code Example :pushpin:](#code-example-pushpin)
- [Credits :cat::handshake:](#credits-cathandshake)
- [License :bookmark:](#license-bookmark)

## Motivation :exclamation:

We've created this repo to easily manage Our work on Basics-Of-Software-Development-On-.Net

## Code style :scroll:

We are using [Codacy](https://www.codacy.com/) to automate Our code quality.
 
## Screenshots :camera:

> Nothing right now

## Tech/framework used :wrench:

**Built with**

- [Visual Studio](https://visualstudio.microsoft.com/)

## Code Example :pushpin:

```csharp
    /// <summary>
		/// Initialization Constructor
		/// </summary>
		/// <param name="roomID"></param>
		/// <param name="roomNumber"></param>
		/// <param name="roomName"></param>
		/// <param name="roomSize"></param>
		/// <param name="hotel"></param>
		/// <param name="tv"></param>
		/// <param name="roomType"></param>
		/// <param name="numberOfBeds"></param>
		/// <param name="balcony"></param>
		public Room(int roomID, int roomNumber, string roomName,
			int roomSize, Hotel hotel, bool? tv, string roomType,
			int numberOfBeds, bool? balcony)
		{
			RoomID = roomID;
			RoomNumber = roomNumber;
			RoomName = roomName;
			RoomSize = roomSize;
			Hotel = hotel;
			TV = tv;
			RoomType = roomType;
			NumberOfBeds = numberOfBeds;
			Balcony = balcony;

			Console.WriteLine($"Додано кiмнату номер {RoomNumber} готелю " +
				$"{Hotel.HotelName}");
		}
```

## Credits :cat::handshake:

| <a href="https://github.com/mezgoodle" target="_blank">**Mezgoodle⭐️**</a> | <a href="https://github.com/Dmytrenko-Roman" target="_blank">**Dmytrenko-Roman**</a> | <a href="https://github.com/fhrr-sht" target="_blank">**Fhrr-sht**</a> | <a href="https://github.com/VsIG-official" target="_blank">**VsIG**</a> |
| :---: |:---:| :---:| :---: |
| [![Mezgoodle](https://avatars.githubusercontent.com/u/41520940?s=400&u=530e013f3714e81792fc6b99399c7a6eda6ea63d&v=4)](https://github.com/mezgoodle) | [![Dmytrenko-Roman](https://avatars.githubusercontent.com/u/54878089?s=400&u=075796965fc5db27cc5b6b179b9325bf312ce0b9&v=4)](https://github.com/Dmytrenko-Roman) | [![Fhrr-Sht](https://avatars.githubusercontent.com/u/54956154?s=400&v=4)](https://github.com/fhrr-sht) | [![VsIG](https://avatars0.githubusercontent.com/u/50269023?s=400&u=522283a8fce57866b73427f94a742fb83e0b1b40&v=4)](https://github.com/VsIG-official)  |
| <a href="https://github.com/mezgoodle" target="_blank">`github.com/mezgoodle`</a> | <a href="https://github.com/Dmytrenko-Roman" target="_blank">`github.com/Dmytrenko-Roman`</a> | <a href="https://github.com/fhrr-sht" target="_blank">`github.com/fhrr-sht`</a> | <a href="https://github.com/VsIG-official" target="_blank">`github.com/VsIG-official`</a> |

## License :bookmark:

MIT © [Mezidia](https://github.com/mezidia)
