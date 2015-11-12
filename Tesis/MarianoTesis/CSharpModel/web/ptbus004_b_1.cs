/*
               File: PTBUS004_b_1
        Description: Stub for PTBUS004_b_1
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:13.64
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Web.Services.Protocols;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
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
   public class ptbus004_b_1 : GXProcedure
   {
      public ptbus004_b_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus004_b_1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_cTTBUS_Id ,
                           ref long aP1_PRC_NRO )
      {
         this.AV2cTTBUS_Id = aP0_cTTBUS_Id;
         this.AV3PRC_NRO = aP1_PRC_NRO;
         initialize();
         executePrivate();
         aP0_cTTBUS_Id=this.AV2cTTBUS_Id;
         aP1_PRC_NRO=this.AV3PRC_NRO;
      }

      public long executeUdp( ref String aP0_cTTBUS_Id )
      {
         this.AV2cTTBUS_Id = aP0_cTTBUS_Id;
         this.AV3PRC_NRO = aP1_PRC_NRO;
         initialize();
         executePrivate();
         aP0_cTTBUS_Id=this.AV2cTTBUS_Id;
         aP1_PRC_NRO=this.AV3PRC_NRO;
         return AV3PRC_NRO ;
      }

      public void executeSubmit( ref String aP0_cTTBUS_Id ,
                                 ref long aP1_PRC_NRO )
      {
         ptbus004_b_1 objptbus004_b_1;
         objptbus004_b_1 = new ptbus004_b_1();
         objptbus004_b_1.AV2cTTBUS_Id = aP0_cTTBUS_Id;
         objptbus004_b_1.AV3PRC_NRO = aP1_PRC_NRO;
         objptbus004_b_1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus004_b_1.executePrivateCatch ));
         aP0_cTTBUS_Id=this.AV2cTTBUS_Id;
         aP1_PRC_NRO=this.AV3PRC_NRO;
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
         args = new Object[] {(String)AV2cTTBUS_Id,(long)AV3PRC_NRO} ;
         ClassLoader.Execute("aptbus004_b_1","GeneXus.Programs.aptbus004_b_1", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 2 ) )
         {
            AV2cTTBUS_Id = (String)(args[0]) ;
            AV3PRC_NRO = (long)(args[1]) ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private long AV3PRC_NRO ;
      private String AV2cTTBUS_Id ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_cTTBUS_Id ;
      private long aP1_PRC_NRO ;
      private Object[] args ;
   }

}
