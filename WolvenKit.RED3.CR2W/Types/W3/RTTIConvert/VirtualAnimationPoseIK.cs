using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VirtualAnimationPoseIK : CVariable
	{
		[Ordinal(1)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(2)] [RED("ids", 2,0)] 		public CArray<CEnum<ETCrEffectorId>> Ids { get; set;}

		[Ordinal(3)] [RED("positionsMS", 2,0)] 		public CArray<Vector> PositionsMS { get; set;}

		[Ordinal(4)] [RED("rotationsMS", 2,0)] 		public CArray<EulerAngles> RotationsMS { get; set;}

		[Ordinal(5)] [RED("weights", 2,0)] 		public CArray<CFloat> Weights { get; set;}

		public VirtualAnimationPoseIK(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}