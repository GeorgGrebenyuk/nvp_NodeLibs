using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.IfcExportSettings 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class IfcExportSettings_Constructor : INode 
	{
		public Renga.IIfcExportSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IIfcExportSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class IfcExportSettings_ConstructorCast : INode 
	{
		public Renga.IIfcExportSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IIfcExportSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ValueMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ValueMappingFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ValueMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ValueMappingFilePath);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("Renga.IfcVersion", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Version = ((Renga.IfcVersion)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Version);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_EntityTypeMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EntityTypeMappingFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class EntityTypeMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityTypeMappingFilePath);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_LayerMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayerMappingFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LayerMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerMappingFilePath);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("ApproximateCurves", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ApproximateCurves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ApproximateCurves = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ApproximateCurves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ApproximateCurves);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("VoidsAsReference", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_VoidsAsReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VoidsAsReference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VoidsAsReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VoidsAsReference);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("SplitObjectsWithLayeredMaterialIntoParts", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_SplitObjectsWithLayeredMaterialIntoParts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SplitObjectsWithLayeredMaterialIntoParts = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SplitObjectsWithLayeredMaterialIntoParts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SplitObjectsWithLayeredMaterialIntoParts);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("GeometricRepresentationWithoutCutting", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_GeometricRepresentationWithoutCutting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GeometricRepresentationWithoutCutting = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GeometricRepresentationWithoutCutting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GeometricRepresentationWithoutCutting);

		}
	}
}
