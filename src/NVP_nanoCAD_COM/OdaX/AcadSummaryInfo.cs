using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface to provide an access to drawing properties such as the Title, Subject, Author, and Keywords properties
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadSummaryInfo 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSummaryInfo_Constructor : INode 
	{
		public OdaX.IAcadSummaryInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSummaryInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSummaryInfo_ConstructorCast : INode 
	{
		public OdaX.IAcadSummaryInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSummaryInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the author value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the author value of the summary information.
	///</summary>
	public class Author : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Author);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the author value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pAuthor", typeof(System.String))]

	///<summary>
	///Specifies or returns the author value of the summary information.
	///</summary>
	public class Set_Author : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Author = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the comments value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the comments value of the summary information.
	///</summary>
	public class Comments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Comments);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the comments value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pComments", typeof(System.String))]

	///<summary>
	///Specifies or returns the comments value of the summary information.
	///</summary>
	public class Set_Comments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Comments = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hyperlink base value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the hyperlink base value of the summary information.
	///</summary>
	public class HyperlinkBase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HyperlinkBase);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hyperlink base value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pHyperlinkBase", typeof(System.String))]

	///<summary>
	///Specifies or returns the hyperlink base value of the summary information.
	///</summary>
	public class Set_HyperlinkBase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HyperlinkBase = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the keywords value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the keywords value of the summary information.
	///</summary>
	public class Keywords : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Keywords);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the keywords value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pKeywords", typeof(System.String))]

	///<summary>
	///Specifies or returns the keywords value of the summary information.
	///</summary>
	public class Set_Keywords : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Keywords = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the login name of the user who last saved the drawing.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the login name of the user who last saved the drawing.
	///</summary>
	public class LastSavedBy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LastSavedBy);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the login name of the user who last saved the drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pLastSavedBy", typeof(System.String))]

	///<summary>
	///Specifies or returns the login name of the user who last saved the drawing.
	///</summary>
	public class Set_LastSavedBy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LastSavedBy = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the revision number value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the revision number value of the summary information.
	///</summary>
	public class RevisionNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RevisionNumber);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the revision number value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pRevisionNumber", typeof(System.String))]

	///<summary>
	///Specifies or returns the revision number value of the summary information.
	///</summary>
	public class Set_RevisionNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RevisionNumber = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the subject value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the subject value of the summary information.
	///</summary>
	public class Subject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Subject);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the subject value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pSubject", typeof(System.String))]

	///<summary>
	///Specifies or returns the subject value of the summary information.
	///</summary>
	public class Set_Subject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Subject = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the title value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the title value of the summary information.
	///</summary>
	public class Title : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Title);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the title value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pTitle", typeof(System.String))]

	///<summary>
	///Specifies or returns the title value of the summary information.
	///</summary>
	public class Set_Title : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Title = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the number of custom information items that have been defined for the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Returns the number of custom information items that have been defined for the summary information.
	///</summary>
	public class NumCustomInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumCustomInfo);

		}
	}


	[NVP_Manifest(
		Text = "Using an index, returns the key and value of custom information that is defined for the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pKey", typeof(System.String))]
	[NodeInput("pValue", typeof(System.String))]

	///<summary>
	///Using an index, returns the key and value of custom information that is defined for the summary information.
	///</summary>
	public class GetCustomByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomByIndex(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Using a key, returns the key and value of custom information that is defined for the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("key", typeof(System.String))]
	[NodeInput("pValue", typeof(System.String))]

	///<summary>
	///Using a key, returns the key and value of custom information that is defined for the summary information.
	///</summary>
	public class GetCustomByKey : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomByKey(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Using an index, specifies the key and value of custom information defined for the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("key", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Using an index, specifies the key and value of custom information defined for the summary information.
	///</summary>
	public class SetCustomByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomByIndex(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Using a key, specifies the key and value of custom information defined for the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("key", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Using a key, specifies the key and value of custom information defined for the summary information.
	///</summary>
	public class SetCustomByKey : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomByKey(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "name) and value to the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("key", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///name) and value to the summary information.
	///</summary>
	public class AddCustomInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddCustomInfo(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Removes custom information using its index.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Removes custom information using its index.
	///</summary>
	public class RemoveCustomByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveCustomByIndex(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Removes custom information using its key.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("key", typeof(System.String))]

	///<summary>
	///Removes custom information using its key.
	///</summary>
	public class RemoveCustomByKey : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveCustomByKey(inputs[1].Value);
			return null;
		}
	}

    [NVP_Manifest(
        Text = "Возвращает все пользовательские свойства чертежа",
        ViewType = "Data")]
    [NodeInput("AcadSummaryInfo", typeof(object))]

    ///<summary>
    ///Removes custom information using its key.
    ///</summary>
    public class GetAll_CustomInfo : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
			OdaX.IAcadSummaryInfo _info = _input0._i as OdaX.IAcadSummaryInfo;
            Dictionary<string, string> items = new Dictionary<string, string>();
			for (int i = 0; i < _info.NumCustomInfo(); i++)
			{
				string custom_prop_name = "";
				string custom_prop_string = "";
				_info.GetCustomByIndex(i, out custom_prop_name, out custom_prop_string);
                
				if (!items.ContainsKey(custom_prop_name)) items.Add(custom_prop_name , custom_prop_string);
            }	
            return new NodeResult(items);
        }
    }

    [NVP_Manifest(
        Text = "Добавляет новые пользовательские свойства. Если Перезапись = true, то при наличии одноименных свойств их значения будут перезаписаны на новые, в противном случае будут оставлены, как есть",
        ViewType = "Data")]
    [NodeInput("AcadSummaryInfo", typeof(object))]
    [NodeInput("Новые свойства", typeof(Dictionary<string, string>))]
    [NodeInput("Перезапись", typeof(bool))]
    ///<summary>
    ///Removes custom information using its key.
    ///</summary>
    public class Add_GroupOfCustomInfo : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
			Dictionary<string, string> _input1 = inputs[1].Value as Dictionary<string, string>;
			bool _input2 = (bool)inputs[2].Value;
            OdaX.IAcadSummaryInfo _info = _input0._i as OdaX.IAcadSummaryInfo;

			var existed_data = new GetAll_CustomInfo().Execute(context, new List<NodeResult>() { inputs[0] }).Value as Dictionary<string, string>;

            foreach (var oneDef in _input1) 
			{
				if (existed_data.ContainsKey(oneDef.Key) && _input2)
				{
					if (_input2) _info.SetCustomByKey(oneDef.Key, oneDef.Value);
				}
				else _info.AddCustomInfo(oneDef.Key, oneDef.Value);
            }
           
            return new NodeResult(null);
        }
    }
}
