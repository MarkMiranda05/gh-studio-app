using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH_Studio {

    internal class Constant {

        public static readonly string rootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GH Live");
        public static readonly string songsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GH Live\\Songs");
        public static readonly string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GH Live\\Config");
        public static readonly string notesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GH Live\\Notes");
        public static readonly string birthdayPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GH Live\\Birthday");
        public static readonly string anniversaryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GH Live\\Anniversary");
        public static readonly string announcementPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GH Live\\Announcement");

        public static readonly string playlistFile = Path.Combine(rootPath, "Playlist.ghlive");
        public static readonly string presenterScreenFile = Path.Combine(configPath, "Presenter Screen.ghlive");
        public static readonly string selectedNoteFile = Path.Combine(configPath, "Selected Note.ghlive");

        public static readonly string announcementFile = Path.Combine(announcementPath, "Announcement.ghlive");

        public static readonly string ghStudioBgImageFile = Path.Combine(configPath, "GHStudioBG.ghlive");

        public static readonly string songFontStyleFile = Path.Combine(configPath, "SongFS.ghlive");
        public static readonly string songFontColorFile = Path.Combine(configPath, "SongFC.ghlive");
        public static readonly string songBgImageFile = Path.Combine(configPath, "SongBG.ghlive");

        public static readonly string bibleFontStyleFile = Path.Combine(configPath, "BibleFS.ghlive");
        public static readonly string bibleFontColorFile = Path.Combine(configPath, "BibleFC.ghlive");
        public static readonly string bibleBgImageFile = Path.Combine(configPath, "BibleBG.ghlive");

        public static readonly string noteFontStyleFile = Path.Combine(configPath, "NoteFS.ghlive");

        public static readonly string birthdayBgImageFile = Path.Combine(configPath, "BirthdayBG.ghlive");
        public static readonly string anniversaryBgImageFile = Path.Combine(configPath, "AnniversaryBG.ghlive");
        public static readonly string announcementBgImageFile = Path.Combine(configPath, "AnnouncementBG.ghlive");
        public static readonly string eventFontStyleFile = Path.Combine(configPath, "EventFS.ghlive");

        public static readonly string[] bibleBooks = { "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel", "1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "Song of Solomon", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter", "2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation" };
        public static readonly int[] bibleChapters = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };
    }
}
