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
   public class SdtSDTAttachs_SDTAttachsItem : GxUserType
   {
      public SdtSDTAttachs_SDTAttachsItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDTAttachs_SDTAttachsItem( IGxContext context )
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
               if ( StringUtil.StrCmp(oReader.LocalName, "NombreArchivo") == 0 )
               {
                  gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo = oReader.Value ;
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
            sName = "SDTAttachs.SDTAttachsItem" ;
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
         oWriter.WriteElement("NombreArchivo", StringUtil.RTrim( gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo));
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("NombreArchivo", (Object)(gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo));
         return  ;
      }

      public String gxTpr_Nombrearchivo
      {
         get {
            return gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo ;
         }

         set {
            gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo_SetNull( )
      {
         gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo = "" ;
         return  ;
      }

      public bool gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtSDTAttachs_SDTAttachsItem_Nombrearchivo ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
