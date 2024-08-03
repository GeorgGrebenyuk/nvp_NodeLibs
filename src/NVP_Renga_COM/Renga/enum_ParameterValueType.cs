using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_ParameterValueType 
{


	[NVP_Manifest(
		Id = "00B8E33C-817B-4BCA-A40D-7D2C682DA8C9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ParameterValueType.enum_ParameterValueType_Undefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ParameterValueType", 
		NodeName = "enum_ParameterValueType_Undefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ParameterValueType_Undefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ParameterValueType.ParameterValueType_Undefined);

		}
	}


	[NVP_Manifest(
		Id = "35D6A400-8B7C-407E-89D5-517773EC9EC2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ParameterValueType.enum_ParameterValueType_Bool", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ParameterValueType", 
		NodeName = "enum_ParameterValueType_Bool", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ParameterValueType_Bool : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ParameterValueType.ParameterValueType_Bool);

		}
	}


	[NVP_Manifest(
		Id = "649C6DBE-50AC-40DA-8D53-30820193FBC8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ParameterValueType.enum_ParameterValueType_Int", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ParameterValueType", 
		NodeName = "enum_ParameterValueType_Int", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ParameterValueType_Int : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ParameterValueType.ParameterValueType_Int);

		}
	}


	[NVP_Manifest(
		Id = "572AE46B-8AB4-4C2F-B84F-DA84212528E5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ParameterValueType.enum_ParameterValueType_Double", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ParameterValueType", 
		NodeName = "enum_ParameterValueType_Double", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ParameterValueType_Double : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ParameterValueType.ParameterValueType_Double);

		}
	}


	[NVP_Manifest(
		Id = "39502D7D-8FA9-4CE5-A9A6-7D8F9CCA28F7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ParameterValueType.enum_ParameterValueType_String", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ParameterValueType", 
		NodeName = "enum_ParameterValueType_String", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ParameterValueType_String : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ParameterValueType.ParameterValueType_String);

		}
	}
}
