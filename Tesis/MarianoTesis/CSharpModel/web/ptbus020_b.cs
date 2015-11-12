/*
               File: PTBUS020_B
        Description: Busco descripción de posición
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:57.20
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
   public class ptbus020_b : GXProcedure
   {
      public ptbus020_b( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus020_b( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_W53POS ,
                           out String aP1_W53DES )
      {
         this.AV8W53POS = aP0_W53POS;
         this.AV9W53DES = "" ;
         initialize();
         executePrivate();
         aP1_W53DES=this.AV9W53DES;
      }

      public String executeUdp( short aP0_W53POS )
      {
         this.AV8W53POS = aP0_W53POS;
         this.AV9W53DES = "" ;
         initialize();
         executePrivate();
         aP1_W53DES=this.AV9W53DES;
         return AV9W53DES ;
      }

      public void executeSubmit( short aP0_W53POS ,
                                 out String aP1_W53DES )
      {
         ptbus020_b objptbus020_b;
         objptbus020_b = new ptbus020_b();
         objptbus020_b.AV8W53POS = aP0_W53POS;
         objptbus020_b.AV9W53DES = "" ;
         objptbus020_b.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus020_b.executePrivateCatch ));
         aP1_W53DES=this.AV9W53DES;
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
         AV9W53DES = "" ;
         /* Using cursor P002U2 */
         pr_default.execute(0, new Object[] {AV8W53POS});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31W53POS = P002U2_A31W53POS[0] ;
            A32W53DES = P002U2_A32W53DES[0] ;
            AV9W53DES = StringUtil.Trim( A32W53DES) ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
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
         P002U2_A31W53POS = new short[1] ;
         P002U2_A32W53DES = new String[] {""} ;
         A32W53DES = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus020_b__default(),
            new Object[][] {
                new Object[] {
               P002U2_A31W53POS, P002U2_A32W53DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8W53POS ;
      private short A31W53POS ;
      private String AV9W53DES ;
      private String scmdbuf ;
      private String A32W53DES ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P002U2_A31W53POS ;
      private String[] P002U2_A32W53DES ;
      private String aP1_W53DES ;
   }

   public class ptbus020_b__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002U2 ;
          prmP002U2 = new Object[] {
          new Object[] {"@AV8W53POS",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002U2", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @AV8W53POS ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002U2,1,0,false,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
