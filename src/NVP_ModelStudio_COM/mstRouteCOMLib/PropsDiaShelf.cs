using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IPropsDiaShelf Interface
///</summary>
namespace mstRouteCOMLib.PropsDiaShelf 
{

	[NVP_Manifest(
		Id = "169FF6C3-22A1-4DEA-B15A-C53C653C5699", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.PropsDiaShelf.PropsDiaShelf_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.PropsDiaShelf", 
		NodeName = "_PropsDiaShelf_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaShelf_Constructor : INode 
	{
		public mstRouteCOMLib.IPropsDiaShelf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstRouteCOMLib.IPropsDiaShelf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "33E9570B-E5EF-43DF-9697-070C6E6F6185", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.PropsDiaShelf.PropsDiaShelf_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.PropsDiaShelf", 
		NodeName = "_PropsDiaShelf_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaShelf_ConstructorCast : INode 
	{
		public mstRouteCOMLib.IPropsDiaShelf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstRouteCOMLib.IPropsDiaShelf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
