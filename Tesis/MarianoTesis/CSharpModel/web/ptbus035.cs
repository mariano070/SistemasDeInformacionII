/*
               File: PTBUS035
        Description: Stub for PTBUS035
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:54.46
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
   public class ptbus035 : GXProcedure
   {
      public ptbus035( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus035( IGxContext context )
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

      public void execute( ref String aP0_NOMBRE_REPORTE ,
                           ref String aP1_USUARIO ,
                           ref short aP2_TTBUS7_Pos ,
                           ref String aP3_TTBUS7_CodResp )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4TTBUS7_Pos = aP2_TTBUS7_Pos;
         this.AV5TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_Pos=this.AV4TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV5TTBUS7_CodResp;
      }

      public String executeUdp( ref String aP0_NOMBRE_REPORTE ,
                                ref String aP1_USUARIO ,
                                ref short aP2_TTBUS7_Pos )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4TTBUS7_Pos = aP2_TTBUS7_Pos;
         this.AV5TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_Pos=this.AV4TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV5TTBUS7_CodResp;
         return AV5TTBUS7_CodResp ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO ,
                                 ref short aP2_TTBUS7_Pos ,
                                 ref String aP3_TTBUS7_CodResp )
      {
         ptbus035 objptbus035;
         objptbus035 = new ptbus035();
         objptbus035.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objptbus035.AV3USUARIO = aP1_USUARIO;
         objptbus035.AV4TTBUS7_Pos = aP2_TTBUS7_Pos;
         objptbus035.AV5TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         objptbus035.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus035.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_Pos=this.AV4TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV5TTBUS7_CodResp;
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
         args = new Object[] {(String)AV2NOMBRE_REPORTE,(String)AV3USUARIO,(short)AV4TTBUS7_Pos,(String)AV5TTBUS7_CodResp} ;
         ClassLoader.Execute("aptbus035","GeneXus.Programs.aptbus035", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 4 ) )
         {
            AV2NOMBRE_REPORTE = (String)(args[0]) ;
            AV3USUARIO = (String)(args[1]) ;
            AV4TTBUS7_Pos = (short)(args[2]) ;
            AV5TTBUS7_CodResp = (String)(args[3]) ;
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

      private short AV4TTBUS7_Pos ;
      private String AV2NOMBRE_REPORTE ;
      private String AV3USUARIO ;
      private String AV5TTBUS7_CodResp ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private short aP2_TTBUS7_Pos ;
      private String aP3_TTBUS7_CodResp ;
      private Object[] args ;
   }

}
