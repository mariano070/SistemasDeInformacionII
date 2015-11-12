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
   public class SdtFisheyeData_FisheyeDataItem : GxUserType
   {
      public SdtFisheyeData_FisheyeDataItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtFisheyeData_FisheyeDataItem( IGxContext context )
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
               if ( StringUtil.StrCmp(oReader.LocalName, "Description") == 0 )
               {
                  gxTv_SdtFisheyeData_FisheyeDataItem_Description = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Image") == 0 )
               {
                  gxTv_SdtFisheyeData_FisheyeDataItem_Image = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Link") == 0 )
               {
                  gxTv_SdtFisheyeData_FisheyeDataItem_Link = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Id") == 0 )
               {
                  gxTv_SdtFisheyeData_FisheyeDataItem_Id = oReader.Value ;
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
            sName = "FisheyeData.FisheyeDataItem" ;
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
         oWriter.WriteElement("Description", StringUtil.RTrim( gxTv_SdtFisheyeData_FisheyeDataItem_Description));
         oWriter.WriteElement("Image", StringUtil.RTrim( gxTv_SdtFisheyeData_FisheyeDataItem_Image));
         oWriter.WriteElement("Link", StringUtil.RTrim( gxTv_SdtFisheyeData_FisheyeDataItem_Link));
         oWriter.WriteElement("Id", StringUtil.RTrim( gxTv_SdtFisheyeData_FisheyeDataItem_Id));
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("Description", (Object)(gxTv_SdtFisheyeData_FisheyeDataItem_Description));
         AddObjectProperty("Image", (Object)(gxTv_SdtFisheyeData_FisheyeDataItem_Image));
         AddObjectProperty("Link", (Object)(gxTv_SdtFisheyeData_FisheyeDataItem_Link));
         AddObjectProperty("Id", (Object)(gxTv_SdtFisheyeData_FisheyeDataItem_Id));
         return  ;
      }

      public String gxTpr_Description
      {
         get {
            return gxTv_SdtFisheyeData_FisheyeDataItem_Description ;
         }

         set {
            gxTv_SdtFisheyeData_FisheyeDataItem_Description = (String)(value) ;
         }

      }

      public void gxTv_SdtFisheyeData_FisheyeDataItem_Description_SetNull( )
      {
         gxTv_SdtFisheyeData_FisheyeDataItem_Description = "" ;
         return  ;
      }

      public bool gxTv_SdtFisheyeData_FisheyeDataItem_Description_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Image
      {
         get {
            return gxTv_SdtFisheyeData_FisheyeDataItem_Image ;
         }

         set {
            gxTv_SdtFisheyeData_FisheyeDataItem_Image = (String)(value) ;
         }

      }

      public void gxTv_SdtFisheyeData_FisheyeDataItem_Image_SetNull( )
      {
         gxTv_SdtFisheyeData_FisheyeDataItem_Image = "" ;
         return  ;
      }

      public bool gxTv_SdtFisheyeData_FisheyeDataItem_Image_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Link
      {
         get {
            return gxTv_SdtFisheyeData_FisheyeDataItem_Link ;
         }

         set {
            gxTv_SdtFisheyeData_FisheyeDataItem_Link = (String)(value) ;
         }

      }

      public void gxTv_SdtFisheyeData_FisheyeDataItem_Link_SetNull( )
      {
         gxTv_SdtFisheyeData_FisheyeDataItem_Link = "" ;
         return  ;
      }

      public bool gxTv_SdtFisheyeData_FisheyeDataItem_Link_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Id
      {
         get {
            return gxTv_SdtFisheyeData_FisheyeDataItem_Id ;
         }

         set {
            gxTv_SdtFisheyeData_FisheyeDataItem_Id = (String)(value) ;
         }

      }

      public void gxTv_SdtFisheyeData_FisheyeDataItem_Id_SetNull( )
      {
         gxTv_SdtFisheyeData_FisheyeDataItem_Id = "" ;
         return  ;
      }

      public bool gxTv_SdtFisheyeData_FisheyeDataItem_Id_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtFisheyeData_FisheyeDataItem_Description = "" ;
         gxTv_SdtFisheyeData_FisheyeDataItem_Image = "" ;
         gxTv_SdtFisheyeData_FisheyeDataItem_Link = "" ;
         gxTv_SdtFisheyeData_FisheyeDataItem_Id = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtFisheyeData_FisheyeDataItem_Description ;
      protected String gxTv_SdtFisheyeData_FisheyeDataItem_Image ;
      protected String gxTv_SdtFisheyeData_FisheyeDataItem_Link ;
      protected String gxTv_SdtFisheyeData_FisheyeDataItem_Id ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
