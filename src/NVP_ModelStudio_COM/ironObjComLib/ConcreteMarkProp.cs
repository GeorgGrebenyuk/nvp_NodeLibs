using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IConcreteMarkProp Interface
///</summary>
namespace ironObjComLib.ConcreteMarkProp 
{

	[NVP_Manifest(
		Id = "0B83BE9E-A11E-45FD-B3B3-10F6F3098527", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.ConcreteMarkProp.ConcreteMarkProp_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.ConcreteMarkProp", 
		NodeName = "_ConcreteMarkProp_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ConcreteMarkProp_Constructor : INode 
	{
		public ironObjComLib.IConcreteMarkProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IConcreteMarkProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "25704D6C-6B80-42E9-93C8-909E04E72921", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.ConcreteMarkProp.ConcreteMarkProp_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.ConcreteMarkProp", 
		NodeName = "_ConcreteMarkProp_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ConcreteMarkProp_ConstructorCast : INode 
	{
		public ironObjComLib.IConcreteMarkProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IConcreteMarkProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
