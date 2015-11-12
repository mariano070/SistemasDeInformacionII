/*
               File: PCTL004
        Description: INCREMENTA Nº SECUENCIA (C/S)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:52.88
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
   public class pctl004 : GXProcedure
   {
      public pctl004( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pctl004( IGxContext context )
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

      public void execute( ref String aP0_CTM_SIS ,
                           ref String aP1_CTM_TDO ,
                           ref long aP2_CTMNUM )
      {
         this.A88CTM_SIS = aP0_CTM_SIS;
         this.A89CTM_TDO = aP1_CTM_TDO;
         this.AV8CTMNUM = aP2_CTMNUM;
         initialize();
         executePrivate();
         aP0_CTM_SIS=this.A88CTM_SIS;
         aP1_CTM_TDO=this.A89CTM_TDO;
         aP2_CTMNUM=this.AV8CTMNUM;
      }

      public long executeUdp( ref String aP0_CTM_SIS ,
                              ref String aP1_CTM_TDO )
      {
         this.A88CTM_SIS = aP0_CTM_SIS;
         this.A89CTM_TDO = aP1_CTM_TDO;
         this.AV8CTMNUM = aP2_CTMNUM;
         initialize();
         executePrivate();
         aP0_CTM_SIS=this.A88CTM_SIS;
         aP1_CTM_TDO=this.A89CTM_TDO;
         aP2_CTMNUM=this.AV8CTMNUM;
         return AV8CTMNUM ;
      }

      public void executeSubmit( ref String aP0_CTM_SIS ,
                                 ref String aP1_CTM_TDO ,
                                 ref long aP2_CTMNUM )
      {
         pctl004 objpctl004;
         objpctl004 = new pctl004();
         objpctl004.A88CTM_SIS = aP0_CTM_SIS;
         objpctl004.A89CTM_TDO = aP1_CTM_TDO;
         objpctl004.AV8CTMNUM = aP2_CTMNUM;
         objpctl004.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpctl004.executePrivateCatch ));
         aP0_CTM_SIS=this.A88CTM_SIS;
         aP1_CTM_TDO=this.A89CTM_TDO;
         aP2_CTMNUM=this.AV8CTMNUM;
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
         /* Using cursor P00262 */
         pr_default.execute(0, new Object[] {A88CTM_SIS, A89CTM_TDO});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A91CTM_TNU = P00262_A91CTM_TNU[0] ;
            A90CTM_NUM = P00262_A90CTM_NUM[0] ;
            if ( A90CTM_NUM == A91CTM_TNU )
            {
               AV8CTMNUM = 1 ;
            }
            else
            {
               AV8CTMNUM = (long)(A90CTM_NUM+1) ;
            }
            A90CTM_NUM = AV8CTMNUM ;
            /* Using cursor P00263 */
            pr_default.execute(1, new Object[] {A90CTM_NUM, A88CTM_SIS, A89CTM_TDO});
            pr_default.close(1);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PCTL004");
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
         P00262_A88CTM_SIS = new String[] {""} ;
         P00262_A89CTM_TDO = new String[] {""} ;
         P00262_A91CTM_TNU = new long[1] ;
         P00262_A90CTM_NUM = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pctl004__default(),
            new Object[][] {
                new Object[] {
               P00262_A88CTM_SIS, P00262_A89CTM_TDO, P00262_A91CTM_TNU, P00262_A90CTM_NUM
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private long AV8CTMNUM ;
      private long A91CTM_TNU ;
      private long A90CTM_NUM ;
      private String A88CTM_SIS ;
      private String A89CTM_TDO ;
      private String scmdbuf ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_CTM_SIS ;
      private String aP1_CTM_TDO ;
      private long aP2_CTMNUM ;
      private IDataStoreProvider pr_default ;
      private String[] P00262_A88CTM_SIS ;
      private String[] P00262_A89CTM_TDO ;
      private long[] P00262_A91CTM_TNU ;
      private long[] P00262_A90CTM_NUM ;
   }

   public class pctl004__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00262 ;
          prmP00262 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmP00263 ;
          prmP00263 = new Object[] {
          new Object[] {"@CTM_NUM",SqlDbType.Decimal,12,0} ,
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00262", "SELECT [CTM_SIS], [CTM_TDO], [CTM_TNU], [CTM_NUM] FROM [CTL004] WITH (UPDLOCK) WHERE [CTM_SIS] = @CTM_SIS and [CTM_TDO] = @CTM_TDO ORDER BY [CTM_SIS], [CTM_TDO] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00262,1,0,true,true )
             ,new CursorDef("P00263", "UPDATE [CTL004] SET [CTM_NUM]=@CTM_NUM  WHERE [CTM_SIS] = @CTM_SIS AND [CTM_TDO] = @CTM_TDO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00263)
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
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
       }
    }

 }

}
