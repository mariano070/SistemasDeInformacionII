/*
               File: PTBUS016_2
        Description: Stub for PTBUS016_2
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:12.14
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
   public class ptbus016_2 : GXProcedure
   {
      public ptbus016_2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus016_2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO ,
                           ref short aP1_TTBUS7_Pos ,
                           ref String aP2_TTBUS7_CodResp )
      {
         this.AV2USUARIO = aP0_USUARIO;
         this.AV3TTBUS7_Pos = aP1_TTBUS7_Pos;
         this.AV4TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV2USUARIO;
         aP1_TTBUS7_Pos=this.AV3TTBUS7_Pos;
         aP2_TTBUS7_CodResp=this.AV4TTBUS7_CodResp;
      }

      public String executeUdp( ref String aP0_USUARIO ,
                                ref short aP1_TTBUS7_Pos )
      {
         this.AV2USUARIO = aP0_USUARIO;
         this.AV3TTBUS7_Pos = aP1_TTBUS7_Pos;
         this.AV4TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV2USUARIO;
         aP1_TTBUS7_Pos=this.AV3TTBUS7_Pos;
         aP2_TTBUS7_CodResp=this.AV4TTBUS7_CodResp;
         return AV4TTBUS7_CodResp ;
      }

      public void executeSubmit( ref String aP0_USUARIO ,
                                 ref short aP1_TTBUS7_Pos ,
                                 ref String aP2_TTBUS7_CodResp )
      {
         ptbus016_2 objptbus016_2;
         objptbus016_2 = new ptbus016_2();
         objptbus016_2.AV2USUARIO = aP0_USUARIO;
         objptbus016_2.AV3TTBUS7_Pos = aP1_TTBUS7_Pos;
         objptbus016_2.AV4TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         objptbus016_2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus016_2.executePrivateCatch ));
         aP0_USUARIO=this.AV2USUARIO;
         aP1_TTBUS7_Pos=this.AV3TTBUS7_Pos;
         aP2_TTBUS7_CodResp=this.AV4TTBUS7_CodResp;
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
         args = new Object[] {(String)AV2USUARIO,(short)AV3TTBUS7_Pos,(String)AV4TTBUS7_CodResp} ;
         ClassLoader.Execute("aptbus016_2","GeneXus.Programs.aptbus016_2", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 3 ) )
         {
            AV2USUARIO = (String)(args[0]) ;
            AV3TTBUS7_Pos = (short)(args[1]) ;
            AV4TTBUS7_CodResp = (String)(args[2]) ;
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

      private short AV3TTBUS7_Pos ;
      private String AV2USUARIO ;
      private String AV4TTBUS7_CodResp ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private short aP1_TTBUS7_Pos ;
      private String aP2_TTBUS7_CodResp ;
      private Object[] args ;
   }

}
