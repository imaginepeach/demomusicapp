using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IF
{
    public enum Genre
    {
        Metal, BlackMetal, Pop, Alternative, Poppunk, Metalcore, Deathcore, Gothic, Rock, Powermetal, Country, Kpop, Emo,
        Symphonic, Melodic, PirateMetal, Folk, Celtic, Doom, VikingMetal, HardRock, LightRock, Noisecore, Indie, Gospel, Classical, Techno, Phonk,
        NuMetal, MelodicDeathMetal
    }
    public interface ISong
    {
        string Name { get; set; }
        string Author { get; set; }
        Genre Genre { get; set; }
        bool isTaken { get; set; }
        List<(int, string, string)> Reviews { get; set; }
        string ReviewsJson { get; set; }
    }
}
