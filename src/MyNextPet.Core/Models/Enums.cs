using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MyNextPet.Core.Helpers;


namespace MyNextPet.Core.Models.Enums;

[Flags]
[JsonConverter(typeof(PetfinderStringEnumConverter))]
public enum Coat
{
    Hairless,
    Short,
    Medium,
    Long,
    Wire,
    Curly
}

[Flags]
[JsonConverter(typeof(PetfinderStringEnumConverter))]
public enum Color
{
    [EnumMember(Value = "Apricot / Beige")]
    ApricotBeige,
    Bicolor,
    Black,
    Brindle,
    [EnumMember(Value = "Brown / Chocolate")]
    BrownChocolate,
    Golden,
    [EnumMember(Value = "Gray / Blue / Silver")]
    GreyBlueSilver,
    Harlequin,
    [EnumMember(Value = "Merle (Blue)")]
    MerleBlue,
    [EnumMember(Value = "Merle (Red)")]
    MerleRed,
    [EnumMember(Value = "Red / Chestnut / Orange")]
    RedChestnutOrange,
    Sable,
    [EnumMember(Value ="Tricolor (Brown, Black, & White)")]
    Tricolor,
    [EnumMember(Value = "White / Cream")]
    WhiteCream,
    [EnumMember(Value = "Yellow / Tan / Blond / Fawn")]
    YellowTanBlondFawn,
    [EnumMember(Value = "Black & White / Tuxedo")]
    BlackWhiteTuxedo,
    [EnumMember(Value = "Blue Cream")]
    BlueCream,
    [EnumMember(Value ="Blue Point")]
    BluePoint,
    [EnumMember(Value = "Buff & White")]
    BuffWhite,
    [EnumMember(Value = "Buff / Tan / Fawn")]
    BuffTanFawn,
    Calico,
    [EnumMember(Value = "Chocolate Point")]
    ChocolatePoint,
    [EnumMember(Value = "Cream / Ivory")]
    CreamIvory,
    [EnumMember(Value ="Cream Point")]
    CreamPoint,
    [EnumMember(Value = "Dilute Calico")]
    DiluteCalico,
    [EnumMember(Value ="Dilute Tortoiseshell")]
    DiluteTortoiseshell,
    [EnumMember(Value ="Flame Point")]
    FlamePoint,
    [EnumMember(Value ="Gray & White")]
    GrayWhite,
    [EnumMember(Value ="Gray / Blue / Silver")]
    GrayBlueSilver,
    [EnumMember(Value ="Lilac Point")]
    LilacPoint,
    [EnumMember(Value ="Orange & White")]
    OrangeWhite,
    [EnumMember(Value ="Orange / Red")]
    OrangeRed,
    [EnumMember(Value ="Tabby (Brown / Chocolate)")]
    TabbyBrownChocolate,
    [EnumMember(Value = "Tabby (Buff / Tan / Fawn)")]
    TabbyBuffTanFawn,
    [EnumMember(Value = "Tabby (Gray / Blue / Silver)")]
    TabbyGrayBlueSilver,
    [EnumMember(Value = "Tabby (Leopard / Spotted)")]
    TabbyLeopardSpotted,
    [EnumMember(Value = "Tabby (Orange / Red)")]
    TabbyOrangeRed,
    [EnumMember(Value = "Tabby (Tiger Striped)")]
    TabbyTigerStriped,
    Torbie,
    Tortoiseshell,
    White,
    Agouti,
    Cream,
    Lilac,
    Tan,
    [EnumMember(Value ="Blue / Gray")]
    BlueGray,
    [EnumMember(Value ="Silver Marten")]
    SilverMarten,
    Smoke,
    Albino,
    Champagne,
    Cinnamon,
    Appaloosa,
    Bay,
    Brown,
    Buckskin,
    Cremello,
    Dun,
    Gray,
    Grullo,
    Liver,
    Paint,
    Palomino,
    Perlino,
    Piebald,
    Pinto,
    Blue,
    Buff,
    Orange,
    Yellow,
    Purple,
    Green,
    Iridescent,
    Red,
    Olive,
    Roan,
    Pink,
    Spotted,
    [EnumMember(Value ="White (Dark-Eyed)")]
    WhiteDarkEyed,
    [EnumMember(Value ="Seal Point")]
    SealPoint,
    [EnumMember(Value ="Bay Roan")]
    BayRoan,
    [EnumMember(Value ="Blue Roan")]
    BlueRoan,
    [EnumMember(Value ="Chestnut / Sorrel")]
    ChestnutSorrel,
    [EnumMember(Value ="Dapple Gray")]
    DappleGray,
    [EnumMember(Value ="Red Roan")]
    RedRoan,
    [EnumMember(Value ="Silver Bay")]
    SilverBay,
    [EnumMember(Value ="Silver Buckskin")]
    SilverBuckskin,
    [EnumMember(Value ="Silver Dapple")]
    SilverDapple,
    [EnumMember(Value ="Purple / Violet")]
    PurpleViolet,
    [EnumMember(Value ="Rust / Rufous")]
    RustRofous,
    [EnumMember(Value = "Black & White")]
    BlackWhite

}

[Flags]
[JsonConverter(typeof(PetfinderStringEnumConverter))]
public enum Gender
{
    Male,
    Female,
    Unknown
}
    


