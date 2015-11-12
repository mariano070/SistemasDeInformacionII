using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtSmoothNavMenuData_SmoothNavMenuItem : GxUserType
   {
      public SdtSmoothNavMenuData_SmoothNavMenuItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSmoothNavMenuData_SmoothNavMenuItem( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name ;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read() ;
            nOutParmCount = 0 ;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0 ;
               if ( StringUtil.StrCmp(oReader.LocalName, "Id") == 0 )
               {
                  gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Title") == 0 )
               {
                  gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Description") == 0 )
               {
                  gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Link") == 0 )
               {
                  gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "LinkTarget") == 0 )
               {
                  gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Items") == 0 )
               {
                  if ( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items == null )
                  {
                     gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items = new GxObjectCollection( context, "SmoothNavMenuData.SmoothNavMenuItem", "MarianoTesis", "SdtSmoothNavMenuData_SmoothNavMenuItem", "GeneXus.Programs");
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items.readxml(oReader, "Items") ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               nOutParmCount = (short)(nOutParmCount+1) ;
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( ) ;
                  GXSoapError = (short)(nOutParmCount*-1) ;
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "SmoothNavMenuData.SmoothNavMenuItem" ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "MarianoTesis" ;
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10)) ;
         }
         oWriter.WriteElement("Id", StringUtil.RTrim( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id));
         oWriter.WriteElement("Title", StringUtil.RTrim( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title));
         oWriter.WriteElement("Description", StringUtil.RTrim( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description));
         oWriter.WriteElement("Link", StringUtil.RTrim( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link));
         oWriter.WriteElement("LinkTarget", StringUtil.RTrim( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget));
         if ( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "MarianoTesis") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "MarianoTesis" ;
            }
            else
            {
               sNameSpace1 = "MarianoTesis" ;
            }
            gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items.writexml(oWriter, "Items", sNameSpace1);
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("Id", (Object)(gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id));
         AddObjectProperty("Title", (Object)(gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title));
         AddObjectProperty("Description", (Object)(gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description));
         AddObjectProperty("Link", (Object)(gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link));
         AddObjectProperty("LinkTarget", (Object)(gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget));
         if ( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items != null )
         {
            AddObjectProperty("Items", (Object)(gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items));
         }
         return  ;
      }

      public String gxTpr_Id
      {
         get {
            return gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id ;
         }

         set {
            gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id = (String)(value) ;
         }

      }

      public void gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id_SetNull( )
      {
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id = "" ;
         return  ;
      }

      public bool gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Title
      {
         get {
            return gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title ;
         }

         set {
            gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title = (String)(value) ;
         }

      }

      public void gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title_SetNull( )
      {
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title = "" ;
         return  ;
      }

      public bool gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Description
      {
         get {
            return gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description ;
         }

         set {
            gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description = (String)(value) ;
         }

      }

      public void gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description_SetNull( )
      {
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description = "" ;
         return  ;
      }

      public bool gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Link
      {
         get {
            return gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link ;
         }

         set {
            gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link = (String)(value) ;
         }

      }

      public void gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link_SetNull( )
      {
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link = "" ;
         return  ;
      }

      public bool gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Linktarget
      {
         get {
            return gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget ;
         }

         set {
            gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget = (String)(value) ;
         }

      }

      public void gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget_SetNull( )
      {
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget = "" ;
         return  ;
      }

      public bool gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget_IsNull( )
      {
         return false ;
      }

      public IGxCollection gxTpr_Items
      {
         get {
            if ( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items == null )
            {
               gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items = new GxObjectCollection( context, "SmoothNavMenuData.SmoothNavMenuItem", "MarianoTesis", "SdtSmoothNavMenuData_SmoothNavMenuItem", "GeneXus.Programs");
            }
            return gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items ;
         }

         set {
            gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items = value ;
         }

      }

      public void gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items_SetNull( )
      {
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items = null ;
         return  ;
      }

      public bool gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items_IsNull( )
      {
         if ( gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id = "" ;
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title = "" ;
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description = "" ;
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link = "" ;
         gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Id ;
      protected String gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Title ;
      protected String gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Description ;
      protected String gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Link ;
      protected String gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Linktarget ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
      [ObjectCollection(ItemType=typeof( SdtSmoothNavMenuData_SmoothNavMenuItem ))]
      protected IGxCollection gxTv_SdtSmoothNavMenuData_SmoothNavMenuItem_Items=null ;
   }

}
