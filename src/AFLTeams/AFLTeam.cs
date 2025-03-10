using System.ComponentModel.DataAnnotations;
using EnumFastToStringGenerated;

namespace AFLTeams
{
    [EnumGenerator]
    public enum AFLTeam
    {
        [Display(Name = "Adelaide Crows")]
        AdelaideCrows,

        [Display(Name = "Brisbane Lions")]
        BrisbaneLions,

        [Display(Name = "Carlton")]
        Carlton,

        [Display(Name = "Collingwood")]
        Collingwood,

        [Display(Name = "Essendon")]
        Essendon,

        [Display(Name = "Fremantle")]
        Fremantle,

        [Display(Name = "Geelong")]
        Geelong,

        [Display(Name = "Gold Coast Suns")]
        GoldCoastSuns,

        [Display(Name = "GWS Giants")]
        GWSGiants,

        [Display(Name = "Hawthorn")]
        Hawthorn,

        [Display(Name = "Melbourne")]
        Melbourne,

        [Display(Name = "North Melbourne")]
        NorthMelbourne,

        [Display(Name = "Port Adelaide")]
        PortAdelaide,

        [Display(Name = "Richmond")]
        Richmond,

        [Display(Name = "St Kilda")]
        StKilda,

        [Display(Name = "Sydney Swans")]
        SydneySwans,

        [Display(Name = "West Coast Eagles")]
        WestCoastEagles,

        [Display(Name = "Western Bulldogs")]
        WesternBulldogs
    }
}