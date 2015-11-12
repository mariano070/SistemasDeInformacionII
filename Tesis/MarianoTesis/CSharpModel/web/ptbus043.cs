/*
               File: PTBUS043
        Description: Busca nro. de asociación de bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:54.53
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
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
   public class ptbus043 : GXProcedure
   {
      public ptbus043( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus043( IGxContext context )
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

      public void execute( int aP0_TTBUS3_IdBien ,
                           out int aP1_TTBUS3_NroAsoc )
      {
         this.AV8TTBUS3_IdBien = aP0_TTBUS3_IdBien;
         this.AV10TTBUS3_NroAsoc = 0 ;
         initialize();
         executePrivate();
         aP1_TTBUS3_NroAsoc=this.AV10TTBUS3_NroAsoc;
      }

      public int executeUdp( int aP0_TTBUS3_IdBien )
      {
         this.AV8TTBUS3_IdBien = aP0_TTBUS3_IdBien;
         this.AV10TTBUS3_NroAsoc = 0 ;
         initialize();
         executePrivate();
         aP1_TTBUS3_NroAsoc=this.AV10TTBUS3_NroAsoc;
         return AV10TTBUS3_NroAsoc ;
      }

      public void executeSubmit( int aP0_TTBUS3_IdBien ,
                                 out int aP1_TTBUS3_NroAsoc )
      {
         ptbus043 objptbus043;
         objptbus043 = new ptbus043();
         objptbus043.AV8TTBUS3_IdBien = aP0_TTBUS3_IdBien;
         objptbus043.AV10TTBUS3_NroAsoc = 0 ;
         objptbus043.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus043.executePrivateCatch ));
         aP1_TTBUS3_NroAsoc=this.AV10TTBUS3_NroAsoc;
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
         AV10TTBUS3_NroAsoc = 0 ;
         AV13GXLvl4 = 0 ;
         /* Using cursor P000O2 */
         pr_default.execute(0, new Object[] {AV8TTBUS3_IdBien});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A105TTBUS3_IdBien = P000O2_A105TTBUS3_IdBien[0] ;
            A106TTBUS3_NroAsoc = P000O2_A106TTBUS3_NroAsoc[0] ;
            AV13GXLvl4 = 1 ;
            AV10TTBUS3_NroAsoc = (int)(A106TTBUS3_NroAsoc+1) ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV13GXLvl4 == 0 )
         {
            AV10TTBUS3_NroAsoc = 1 ;
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
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         P000O2_A105TTBUS3_IdBien = new int[1] ;
         P000O2_A106TTBUS3_NroAsoc = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus043__default(),
            new Object[][] {
                new Object[] {
               P000O2_A105TTBUS3_IdBien, P000O2_A106TTBUS3_NroAsoc
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV13GXLvl4 ;
      private int AV8TTBUS3_IdBien ;
      private int AV10TTBUS3_NroAsoc ;
      private int A105TTBUS3_IdBien ;
      private int A106TTBUS3_NroAsoc ;
      private String scmdbuf ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] P000O2_A105TTBUS3_IdBien ;
      private int[] P000O2_A106TTBUS3_NroAsoc ;
      private int aP1_TTBUS3_NroAsoc ;
   }

   public class ptbus043__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000O2 ;
          prmP000O2 = new Object[] {
          new Object[] {"@AV8TTBUS3_IdBien",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000O2", "SELECT TOP 1 [TTBUS3_IdBien], [TTBUS3_NroAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE [TTBUS3_IdBien] = @AV8TTBUS3_IdBien ORDER BY [TTBUS3_IdBien], [TTBUS3_NroAsoc] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000O2,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
