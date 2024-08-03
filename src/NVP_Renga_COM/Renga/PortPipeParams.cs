using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PortPipeParams 
{

	[NVP_Manifest(
		Id = "65942ED8-DA37-473D-893D-317633EC1F1E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortPipeParams.PortPipeParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortPipeParams", 
		NodeName = "_PortPipeParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PortPipeParams_Constructor : INode 
	{
		public Renga.IPortPipeParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPortPipeParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "52F47098-B02F-4101-B0AA-526518DB21CC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortPipeParams.PortPipeParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortPipeParams", 
		NodeName = "_PortPipeParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PortPipeParams_ConstructorCast : INode 
	{
		public Renga.IPortPipeParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPortPipeParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "96E6749E-2F73-4245-96AE-419BF27E7E28", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortPipeParams.ConnectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortPipeParams", 
		NodeName = "ConnectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PortPipeParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionType);

		}
	}


	[NVP_Manifest(
		Id = "FD78C88C-01A2-4B03-BF72-C2C50527DE63", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortPipeParams.NominalDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortPipeParams", 
		NodeName = "NominalDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PortPipeParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NominalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NominalDiameter);

		}
	}
}
