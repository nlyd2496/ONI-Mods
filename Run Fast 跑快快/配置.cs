using System;
using Newtonsoft.Json;
using PeterHan.PLib.Options;

namespace Run_Fast_跑快快
{
    [RestartRequired]
    [JsonObject(MemberSerialization.OptIn)]
	[ConfigFile("Controler.json", true, false)]
    [ModInfo("https://github.com/peteward44/ONIMods", "Run_Fast_跑快快.png", true)]

    public class TestModSettings
	{
        //--------------------------------------------------------------------------------------------------
        [Option("基础速度", "Basic speed", null, Format = "F0")]
		[Limit(1.0, 666.0)]
		[JsonProperty]
		public float a1 { get; set; } = 2f;
        //--------------------------------------------------------------------------------------------------
        [Option("加速", "Accelerate", null, Format = "F0")]
        [Limit(4.0, 666.0)]
        [JsonProperty]
        public float a2 { get; set; } = 4f;
        //--------------------------------------------------------------------------------------------------
        [Option("加加速", "Accelerate + Accelerate", null, Format = "F0")]
        [Limit(6.0, 666.0)]
        [JsonProperty]
        public float a3 { get; set; } = 6f;
        //--------------------------------------------------------------------------------------------------
        [Option("加加加速", "Accelerate + Accelerate + Accelerate", null, Format = "F0")]
        [Limit(8.0, 666.0)]
        [JsonProperty]
        public float a4 { get; set; } = 8f;
        //--------------------------------------------------------------------------------------------------
        [Option("加加加加速", "Accelerate + Accelerate + Accelerate + Accelerate", null, Format = "F0")]
        [Limit(10.0, 666.0)]
        [JsonProperty]
        public float a5 { get; set; } = 10f;
        //--------------------------------------------------------------------------------------------------
    }
}
