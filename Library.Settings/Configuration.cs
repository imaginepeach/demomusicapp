using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using Library.Bll;
using Library.IF;
using Library.Data.Memory;
using Music.Data.Sql;
using Music.Data.Sql;

namespace Library.Settings
{
    public class Configuration
    {
        public Container Container { get; }

        public Configuration()
        {
            Container = new Container();

            Setup();
        }

        public virtual void Setup()
        {
            Container.Register<ISong, Song>(Lifestyle.Transient);
            Container.Register<IFav, Fav>(Lifestyle.Transient);
            Container.Register<IUser, User>(Lifestyle.Transient);
            Container.Register<IMusicApp, Bll.MusicApp>(Lifestyle.Singleton);
            Container.Register<IDataSong<ISong>, SongSqlData>
                (Lifestyle.Singleton);
            Container.Register<IDataFav<IFav>, FavSqlData>
                (Lifestyle.Singleton);
            Container.Register<IDataUser<IUser>, UserSqlData>
                (Lifestyle.Singleton);
        }

    }
}
