using NVP.API.Nodes;

namespace Renga.IfcExportSettings 
{
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


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]
	public class Set_ValueMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ValueMappingFilePath = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	public class ValueMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ValueMappingFilePath);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pIfcVersion", typeof(System.Object))]
	public class Set_Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Version = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	public class Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Version);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]
	public class Set_EntityTypeMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EntityTypeMappingFilePath = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	public class EntityTypeMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityTypeMappingFilePath);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]
	public class Set_LayerMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayerMappingFilePath = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	public class LayerMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerMappingFilePath);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("ApproximateCurves", typeof(System.Object))]
	public class Set_ApproximateCurves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ApproximateCurves = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	public class ApproximateCurves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ApproximateCurves);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("VoidsAsReference", typeof(System.Object))]
	public class Set_VoidsAsReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VoidsAsReference = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	public class VoidsAsReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VoidsAsReference);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("SplitObjectsWithLayeredMaterialIntoParts", typeof(System.Object))]
	public class Set_SplitObjectsWithLayeredMaterialIntoParts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SplitObjectsWithLayeredMaterialIntoParts = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	public class SplitObjectsWithLayeredMaterialIntoParts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SplitObjectsWithLayeredMaterialIntoParts);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("GeometricRepresentationWithoutCutting", typeof(System.Object))]
	public class Set_GeometricRepresentationWithoutCutting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GeometricRepresentationWithoutCutting = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("IfcExportSettings", typeof(object))]
	public class GeometricRepresentationWithoutCutting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GeometricRepresentationWithoutCutting);

		}
	}
}
