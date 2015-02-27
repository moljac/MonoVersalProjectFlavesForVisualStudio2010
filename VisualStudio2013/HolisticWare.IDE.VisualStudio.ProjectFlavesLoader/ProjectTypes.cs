using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.VisualStudio.ProjectFlavesLoader
{
	class ProjectTypes
	{
	}
}



/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class ProjectTypes
{

	private ProjectTypesProjectType[] projectTypeField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("ProjectType")]
	public ProjectTypesProjectType[] ProjectType
	{
		get
		{
			return this.projectTypeField;
		}
		set
		{
			this.projectTypeField = value;
		}
	}
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProjectTypesProjectType
{

	private string guid;

	private string description;

	private string name;

	/// <remarks/>
	public string GUID
	{
		get
		{
			return this.guid;
		}
		set
		{
			this.guid = value;
		}
	}

	/// <remarks/>
	public string Description
	{
		get
		{
			return this.description;
		}
		set
		{
			this.description = value;
		}
	}

	/// <remarks/>
	public string Name
	{
		get
		{
			return this.name;
		}
		set
		{
			this.name = value;
		}
	}
}

