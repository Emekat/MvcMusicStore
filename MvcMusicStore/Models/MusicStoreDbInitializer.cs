﻿using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MvcMusicStoreContext>
    {
        protected override void Seed(MvcMusicStoreContext context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
            base.Seed(context);
        }
    }
}