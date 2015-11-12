using System;
using GeneXus.Builder;
using System.IO;
public class bldaptbus016_2 : GxBaseBuilder
{
   string cs_path = "." ;
   public bldaptbus016_2( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0 ;
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldaptbus016_2 x = new bldaptbus016_2() ;
      x.SetMainSourceFile( "aptbus016_2.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\GeneXus.Programs.Common.rsp");
      return sc ;
   }

   public override ItemCollection GetRuntimeBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\aptbus016_2.dll", cs_path + @"\aptbus016_2.rsp");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtRecentLinksItems_RecentLinksItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtContext.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTabOptions_TabOptionsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTransactionContext.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTransactionContext_Attribute.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDTAttachs_SDTAttachsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTabsMenuData_TabsMenuDataItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTabsMenuData_TabsMenuDataItem_SectionsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMenuData_MenuDataItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxSilentTrnGridCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTrnMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINRecentLinksOptions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINPage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINMessageTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINIMEMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINHttpMethod.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

