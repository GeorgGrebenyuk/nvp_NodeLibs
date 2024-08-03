using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_QuantityType 
{


	[NVP_Manifest(
		Id = "0F263A26-5ABA-4D99-9760-7270B50E959B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_QuantityType.enum_QuantityType_Unknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_QuantityType", 
		NodeName = "enum_QuantityType_Unknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_QuantityType_Unknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.QuantityType.QuantityType_Unknown);

		}
	}


	[NVP_Manifest(
		Id = "5D47973A-987F-4676-817B-1EAE308ABA63", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_QuantityType.enum_QuantityType_Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_QuantityType", 
		NodeName = "enum_QuantityType_Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_QuantityType_Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.QuantityType.QuantityType_Count);

		}
	}


	[NVP_Manifest(
		Id = "FDB46104-E43E-4B18-8870-6BE21DF926C8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_QuantityType.enum_QuantityType_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_QuantityType", 
		NodeName = "enum_QuantityType_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_QuantityType_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.QuantityType.QuantityType_Length);

		}
	}


	[NVP_Manifest(
		Id = "386832B4-5ED3-435E-A6F3-31D93DCEDC9C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_QuantityType.enum_QuantityType_Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_QuantityType", 
		NodeName = "enum_QuantityType_Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_QuantityType_Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.QuantityType.QuantityType_Area);

		}
	}


	[NVP_Manifest(
		Id = "C6910F54-66FE-407D-9C28-3721389FF1A6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_QuantityType.enum_QuantityType_Volume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_QuantityType", 
		NodeName = "enum_QuantityType_Volume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_QuantityType_Volume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.QuantityType.QuantityType_Volume);

		}
	}


	[NVP_Manifest(
		Id = "6E18DEA1-0D50-4C1F-B661-84CE2E4B5133", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_QuantityType.enum_QuantityType_Mass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_QuantityType", 
		NodeName = "enum_QuantityType_Mass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_QuantityType_Mass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.QuantityType.QuantityType_Mass);

		}
	}
}
