
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInvalidProxyMeshNode : worldPrefabProxyMeshNode
	{

		public worldInvalidProxyMeshNode()
		{
			AncestorPrefabProxyMeshNodeID = new();
			OwnerPrefabNodeId = new();
		}
	}
}
