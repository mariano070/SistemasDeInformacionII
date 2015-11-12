/*
               File: ListPrograms
        Description: List Programs
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:10.12
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class listprograms : GXProcedure
   {
      public listprograms( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public listprograms( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out IGxCollection aP0_ProgramNames )
      {
         this.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "MarianoTesis", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV10ProgramNames;
      }

      public IGxCollection executeUdp( )
      {
         this.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "MarianoTesis", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV10ProgramNames;
         return AV10ProgramNames ;
      }

      public void executeSubmit( out IGxCollection aP0_ProgramNames )
      {
         listprograms objlistprograms;
         objlistprograms = new listprograms();
         objlistprograms.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "MarianoTesis", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         objlistprograms.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objlistprograms.executePrivateCatch ));
         aP0_ProgramNames=this.AV10ProgramNames;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "MarianoTesis", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         AV12name = "WWSEG008" ;
         AV13description = "Work With INFO MENUES XS" ;
         AV14link = "wwseg008.aspx" ;
         /* Execute user subroutine: S1139 */
         S1139 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV12name = "WWSEG008L1" ;
         AV13description = "Work With INFO MENUES XS" ;
         AV14link = "wwseg008l1.aspx" ;
         /* Execute user subroutine: S1139 */
         S1139 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV12name = "WWTBUS000" ;
         AV13description = "Trabajar con DE BIENES DE USO" ;
         AV14link = "wwtbus000.aspx" ;
         /* Execute user subroutine: S1139 */
         S1139 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV12name = "WWTBUS002" ;
         AV13description = "Work With ACTUALIZ. DE RUBROSS" ;
         AV14link = "wwtbus002.aspx" ;
         /* Execute user subroutine: S1139 */
         S1139 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV12name = "WWTSEG002" ;
         AV13description = "Trabajar con ACT. USUARIOS" ;
         AV14link = "wwtseg002.aspx" ;
         /* Execute user subroutine: S1139 */
         S1139 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV12name = "WWTSEG003" ;
         AV13description = "Trabajar con ACT. USUARIO/SISTEMAS" ;
         AV14link = "wwtseg003.aspx" ;
         /* Execute user subroutine: S1139 */
         S1139 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV12name = "WWTSEG006" ;
         AV13description = "Work With SESIONES POR USUARIOS" ;
         AV14link = "wwtseg006.aspx" ;
         /* Execute user subroutine: S1139 */
         S1139 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         this.cleanup();
      }

      protected void S1139( )
      {
         /* 'ADDPROGRAM' Routine */
         AV8IsAuthorized = true ;
         new isauthorized(context ).execute(  AV12name, out  AV8IsAuthorized) ;
         if ( AV8IsAuthorized )
         {
            AV11ProgramName = new SdtProgramNames_ProgramName(context) ;
            AV11ProgramName.gxTpr_Name = AV12name ;
            AV11ProgramName.gxTpr_Description = AV13description ;
            AV11ProgramName.gxTpr_Link = AV14link ;
            AV10ProgramNames.Add(AV11ProgramName, 0);
         }
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV12name = "" ;
         AV13description = "" ;
         AV14link = "" ;
         AV11ProgramName = new SdtProgramNames_ProgramName(context);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private bool returnInSub ;
      private bool AV8IsAuthorized ;
      private String AV12name ;
      private String AV13description ;
      private String AV14link ;
      private IGxCollection aP0_ProgramNames ;
      [ObjectCollection(ItemType=typeof( SdtProgramNames_ProgramName ))]
      private IGxCollection AV10ProgramNames ;
      private SdtProgramNames_ProgramName AV11ProgramName ;
   }

}
