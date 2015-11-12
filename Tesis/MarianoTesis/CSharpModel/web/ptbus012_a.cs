/*
               File: PTBUS012_A
        Description: Busca descripción de usuario
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:57.26
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
   public class ptbus012_a : GXProcedure
   {
      public ptbus012_a( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus012_a( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_USU_COD ,
                           out String aP1_USU_DES )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV9USU_DES = "" ;
         initialize();
         executePrivate();
         aP1_USU_DES=this.AV9USU_DES;
      }

      public String executeUdp( String aP0_USU_COD )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV9USU_DES = "" ;
         initialize();
         executePrivate();
         aP1_USU_DES=this.AV9USU_DES;
         return AV9USU_DES ;
      }

      public void executeSubmit( String aP0_USU_COD ,
                                 out String aP1_USU_DES )
      {
         ptbus012_a objptbus012_a;
         objptbus012_a = new ptbus012_a();
         objptbus012_a.AV8USU_COD = aP0_USU_COD;
         objptbus012_a.AV9USU_DES = "" ;
         objptbus012_a.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus012_a.executePrivateCatch ));
         aP1_USU_DES=this.AV9USU_DES;
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
         AV9USU_DES = "" ;
         /* Using cursor P002W2 */
         pr_default.execute(0, new Object[] {AV8USU_COD});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A6USU_COD = P002W2_A6USU_COD[0] ;
            A7USU_DES = P002W2_A7USU_DES[0] ;
            AV9USU_DES = StringUtil.Trim( A7USU_DES) ;
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
         P002W2_A6USU_COD = new String[] {""} ;
         P002W2_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus012_a__default(),
            new Object[][] {
                new Object[] {
               P002W2_A6USU_COD, P002W2_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV8USU_COD ;
      private String AV9USU_DES ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002W2_A6USU_COD ;
      private String[] P002W2_A7USU_DES ;
      private String aP1_USU_DES ;
   }

   public class ptbus012_a__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002W2 ;
          prmP002W2 = new Object[] {
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002W2", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV8USU_COD ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002W2,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
