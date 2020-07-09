﻿using BlueSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Application
{
    public static class ToolBars
    {
        public static List<MenuItem> GetActionRowItems(bool hasNotes = false, bool isDone = false)
        {
            string NoteImage = (hasNotes) ? "Note-Filled" : "Note";
            string DoneImage = (isDone)   ? "Add" : "Close";

            List<MenuItem> list = new List<MenuItem>();

            list.Add(new MenuItem("", "Edit",     "View or edit this action", "", ""));
            list.Add(new MenuItem("", "Building", "List/Add an organization", "", ""));
            list.Add(new MenuItem("", "Person",   "List/Add a contact",       "", ""));
            list.Add(new MenuItem("", NoteImage,  "List/Add a note",          "", ""));
            if (!isDone)
            {
                list.Add(new MenuItem("", "Close", "Mark as done", "", ""));
            }
            else
            {
                list.Add(new MenuItem("", "Add", "Add back into this list", "", ""));
            }
            return list;
        }
        public static List<MenuItem> GetToDoRowItems(bool hasNotes = false, bool isDone = false)
        {
            string NoteImage = (hasNotes) ? "Note-Filled" : "Note";

            List<MenuItem> list = new List<MenuItem>();
            list.Add(new MenuItem("", "Building", "List/Add an Organization", "", ""));
            list.Add(new MenuItem("", "Person",   "List/Add a Contact",       "", ""));
            list.Add(new MenuItem("", NoteImage,  "List/Add a Note",          "", ""));
            if (!isDone)
            {
                list.Add(new MenuItem("", "Close", "Mark as done", "", ""));
            }
            else
            {
                list.Add(new MenuItem("", "Add", "Add back into this list", "", ""));
            }
            return list;

        }
    }
}
