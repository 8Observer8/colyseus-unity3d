﻿using System;

using JsonDiffPatch;
using Newtonsoft.Json.Linq;

namespace Colyseus
{
	public class MessageEventArgs : EventArgs
	{
		public Room room = null;
		public object data = null;

		public MessageEventArgs (Room room, object data = null)
		{
			this.room = room;
			this.data = data;
		}
	}

	public class RoomUpdateEventArgs : EventArgs
	{
		
		public Room room = null;
		public JToken data = null;
		public PatchDocument patches;

		public RoomUpdateEventArgs (Room room, JToken data, PatchDocument patches = null)
		{
			this.room = room;
			this.data = data;
			this.patches = patches;
		}
	}
}

