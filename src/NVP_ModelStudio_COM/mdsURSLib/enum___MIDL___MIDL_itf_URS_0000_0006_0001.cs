using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001 
{


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_appCustom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(mdsURSLib.__MIDL___MIDL_itf_URS_0000_0006_0001.appCustom);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_appMSWord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(mdsURSLib.__MIDL___MIDL_itf_URS_0000_0006_0001.appMSWord);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_appMSExcel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(mdsURSLib.__MIDL___MIDL_itf_URS_0000_0006_0001.appMSExcel);

		}
	}
}
