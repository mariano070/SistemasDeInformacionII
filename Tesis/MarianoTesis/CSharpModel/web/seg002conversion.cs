/*
               File: SEG002Conversion
        Description: Conversion for table SEG002
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:5:33.14
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class seg002conversion : GXProcedure
   {
      public seg002conversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public seg002conversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         seg002conversion objseg002conversion;
         objseg002conversion = new seg002conversion();
         objseg002conversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objseg002conversion.executePrivateCatch ));
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
         /* Using cursor SEG002CONV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A258USU_ERR = SEG002CONV2_A258USU_ERR[0] ;
            A257USU_ACTIV = SEG002CONV2_A257USU_ACTIV[0] ;
            A256USU_STS = SEG002CONV2_A256USU_STS[0] ;
            A255USU_NROW = SEG002CONV2_A255USU_NROW[0] ;
            A254USU_TIPW = SEG002CONV2_A254USU_TIPW[0] ;
            A249USU_MAIW = SEG002CONV2_A249USU_MAIW[0] ;
            n249USU_MAIW = SEG002CONV2_n249USU_MAIW[0] ;
            A180USU_INT = SEG002CONV2_A180USU_INT[0] ;
            A252USU_LEG = SEG002CONV2_A252USU_LEG[0] ;
            A251USU_EMP = SEG002CONV2_A251USU_EMP[0] ;
            A250USU_CDA = SEG002CONV2_A250USU_CDA[0] ;
            A156USU_FEC = SEG002CONV2_A156USU_FEC[0] ;
            A253USU_CLAK = SEG002CONV2_A253USU_CLAK[0] ;
            n253USU_CLAK = SEG002CONV2_n253USU_CLAK[0] ;
            A155USU_CLA = SEG002CONV2_A155USU_CLA[0] ;
            A7USU_DES = SEG002CONV2_A7USU_DES[0] ;
            A6USU_COD = SEG002CONV2_A6USU_COD[0] ;
            /*
               INSERT RECORD ON TABLE GXA0015

            */
            AV2USU_COD = A6USU_COD ;
            AV3USU_DES = A7USU_DES ;
            AV4USU_CLA = A155USU_CLA ;
            if ( SEG002CONV2_n253USU_CLAK[0] )
            {
               AV5USU_CLAK = "" ;
               nV5USU_CLAK = false ;
               nV5USU_CLAK = true ;
            }
            else
            {
               AV5USU_CLAK = A253USU_CLAK ;
               nV5USU_CLAK = false ;
            }
            AV6USU_FEC = A156USU_FEC ;
            AV7USU_CDA = A250USU_CDA ;
            AV8USU_EMP = A251USU_EMP ;
            AV9USU_LEG = A252USU_LEG ;
            AV10USU_INT = A180USU_INT ;
            if ( SEG002CONV2_n249USU_MAIW[0] )
            {
               AV11USU_MAIW = "" ;
               nV11USU_MAIW = false ;
               nV11USU_MAIW = true ;
            }
            else
            {
               AV11USU_MAIW = A249USU_MAIW ;
               nV11USU_MAIW = false ;
            }
            AV12USU_TIPW = A254USU_TIPW ;
            AV13USU_NROW = A255USU_NROW ;
            AV14USU_STS = A256USU_STS ;
            AV15USU_ACTIV = A257USU_ACTIV ;
            AV16USU_ERR = A258USU_ERR ;
            /* Using cursor SEG002CONV3 */
            pr_default.execute(1, new Object[] {AV2USU_COD, AV3USU_DES, AV4USU_CLA, nV5USU_CLAK, AV5USU_CLAK, AV6USU_FEC, AV7USU_CDA, AV8USU_EMP, AV9USU_LEG, AV10USU_INT, nV11USU_MAIW, AV11USU_MAIW, AV12USU_TIPW, AV13USU_NROW, AV14USU_STS, AV15USU_ACTIV, AV16USU_ERR});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
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
         SEG002CONV2_A258USU_ERR = new short[1] ;
         SEG002CONV2_A257USU_ACTIV = new DateTime[] {DateTime.MinValue} ;
         SEG002CONV2_A256USU_STS = new short[1] ;
         SEG002CONV2_A255USU_NROW = new long[1] ;
         SEG002CONV2_A254USU_TIPW = new String[] {""} ;
         SEG002CONV2_A249USU_MAIW = new String[] {""} ;
         SEG002CONV2_n249USU_MAIW = new bool[] {false} ;
         SEG002CONV2_A180USU_INT = new String[] {""} ;
         SEG002CONV2_A252USU_LEG = new int[1] ;
         SEG002CONV2_A251USU_EMP = new String[] {""} ;
         SEG002CONV2_A250USU_CDA = new String[] {""} ;
         SEG002CONV2_A156USU_FEC = new DateTime[] {DateTime.MinValue} ;
         SEG002CONV2_A253USU_CLAK = new String[] {""} ;
         SEG002CONV2_n253USU_CLAK = new bool[] {false} ;
         SEG002CONV2_A155USU_CLA = new String[] {""} ;
         SEG002CONV2_A7USU_DES = new String[] {""} ;
         SEG002CONV2_A6USU_COD = new String[] {""} ;
         A257USU_ACTIV = (DateTime)(DateTime.MinValue) ;
         A254USU_TIPW = "" ;
         A249USU_MAIW = "" ;
         A180USU_INT = "" ;
         A251USU_EMP = "" ;
         A250USU_CDA = "" ;
         A156USU_FEC = DateTime.MinValue ;
         A253USU_CLAK = "" ;
         A155USU_CLA = "" ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         AV2USU_COD = "" ;
         AV3USU_DES = "" ;
         AV4USU_CLA = "" ;
         AV5USU_CLAK = "" ;
         AV6USU_FEC = DateTime.MinValue ;
         AV7USU_CDA = "" ;
         AV8USU_EMP = "" ;
         AV10USU_INT = "" ;
         AV11USU_MAIW = "" ;
         AV12USU_TIPW = "" ;
         AV15USU_ACTIV = (DateTime)(DateTime.MinValue) ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seg002conversion__default(),
            new Object[][] {
                new Object[] {
               SEG002CONV2_A258USU_ERR, SEG002CONV2_A257USU_ACTIV, SEG002CONV2_A256USU_STS, SEG002CONV2_A255USU_NROW, SEG002CONV2_A254USU_TIPW, SEG002CONV2_A249USU_MAIW, SEG002CONV2_n249USU_MAIW, SEG002CONV2_A180USU_INT, SEG002CONV2_A252USU_LEG, SEG002CONV2_A251USU_EMP,
               SEG002CONV2_A250USU_CDA, SEG002CONV2_A156USU_FEC, SEG002CONV2_A253USU_CLAK, SEG002CONV2_n253USU_CLAK, SEG002CONV2_A155USU_CLA, SEG002CONV2_A7USU_DES, SEG002CONV2_A6USU_COD
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A258USU_ERR ;
      private short A256USU_STS ;
      private short AV14USU_STS ;
      private short AV16USU_ERR ;
      private int A252USU_LEG ;
      private int GIGXA0015 ;
      private int AV9USU_LEG ;
      private long A255USU_NROW ;
      private long AV13USU_NROW ;
      private String scmdbuf ;
      private String A254USU_TIPW ;
      private String A180USU_INT ;
      private String A251USU_EMP ;
      private String A250USU_CDA ;
      private String A253USU_CLAK ;
      private String A155USU_CLA ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String AV2USU_COD ;
      private String AV3USU_DES ;
      private String AV4USU_CLA ;
      private String AV5USU_CLAK ;
      private String AV7USU_CDA ;
      private String AV8USU_EMP ;
      private String AV10USU_INT ;
      private String AV12USU_TIPW ;
      private String Gx_emsg ;
      private DateTime A257USU_ACTIV ;
      private DateTime AV15USU_ACTIV ;
      private DateTime A156USU_FEC ;
      private DateTime AV6USU_FEC ;
      private bool n249USU_MAIW ;
      private bool n253USU_CLAK ;
      private bool nV5USU_CLAK ;
      private bool nV11USU_MAIW ;
      private String A249USU_MAIW ;
      private String AV11USU_MAIW ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] SEG002CONV2_A258USU_ERR ;
      private DateTime[] SEG002CONV2_A257USU_ACTIV ;
      private short[] SEG002CONV2_A256USU_STS ;
      private long[] SEG002CONV2_A255USU_NROW ;
      private String[] SEG002CONV2_A254USU_TIPW ;
      private String[] SEG002CONV2_A249USU_MAIW ;
      private bool[] SEG002CONV2_n249USU_MAIW ;
      private String[] SEG002CONV2_A180USU_INT ;
      private int[] SEG002CONV2_A252USU_LEG ;
      private String[] SEG002CONV2_A251USU_EMP ;
      private String[] SEG002CONV2_A250USU_CDA ;
      private DateTime[] SEG002CONV2_A156USU_FEC ;
      private String[] SEG002CONV2_A253USU_CLAK ;
      private bool[] SEG002CONV2_n253USU_CLAK ;
      private String[] SEG002CONV2_A155USU_CLA ;
      private String[] SEG002CONV2_A7USU_DES ;
      private String[] SEG002CONV2_A6USU_COD ;
   }

   public class seg002conversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmSEG002CONV2 ;
          prmSEG002CONV2 = new Object[] {
          } ;
          Object[] prmSEG002CONV3 ;
          prmSEG002CONV3 = new Object[] {
          new Object[] {"@AV2USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV3USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@AV4USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@AV5USU_CLAK",SqlDbType.Char,32,0} ,
          new Object[] {"@AV6USU_FEC",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV7USU_CDA",SqlDbType.Char,8,0} ,
          new Object[] {"@AV8USU_EMP",SqlDbType.Char,3,0} ,
          new Object[] {"@AV9USU_LEG",SqlDbType.Int,5,0} ,
          new Object[] {"@AV10USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@AV11USU_MAIW",SqlDbType.VarChar,256,0} ,
          new Object[] {"@AV12USU_TIPW",SqlDbType.Char,1,0} ,
          new Object[] {"@AV13USU_NROW",SqlDbType.Decimal,11,0} ,
          new Object[] {"@AV14USU_STS",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV15USU_ACTIV",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV16USU_ERR",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SEG002CONV2", "SELECT [USU_ERR], [USU_ACTIV], [USU_STS], [USU_NROW], [USU_TIPW], [USU_MAIW], [USU_INT], [USU_LEG], [USU_EMP], [USU_CDA], [USU_FEC], [USU_CLAK], [USU_CLA], [USU_DES], [USU_COD] FROM [SEG002] ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSEG002CONV2,100,0,true,false )
             ,new CursorDef("SEG002CONV3", "INSERT INTO [GXA0015] ([USU_COD], [USU_DES], [USU_CLA], [USU_CLAK], [USU_FEC], [USU_CDA], [USU_EMP], [USU_LEG], [USU_INT], [USU_MAIW], [USU_TIPW], [USU_NROW], [USU_STS], [USU_ACTIV], [USU_ERR]) VALUES (@AV2USU_COD, @AV3USU_DES, @AV4USU_CLA, @AV5USU_CLAK, @AV6USU_FEC, @AV7USU_CDA, @AV8USU_EMP, @AV9USU_LEG, @AV10USU_INT, @AV11USU_MAIW, @AV12USU_TIPW, @AV13USU_NROW, @AV14USU_STS, @AV15USU_ACTIV, @AV16USU_ERR)", GxErrorMask.GX_NOMASK,prmSEG002CONV3)
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 10) ;
                ((int[]) buf[8])[0] = rslt.getInt(8) ;
                ((String[]) buf[9])[0] = rslt.getString(9, 3) ;
                ((String[]) buf[10])[0] = rslt.getString(10, 8) ;
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(11) ;
                ((String[]) buf[12])[0] = rslt.getString(12, 32) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(12);
                ((String[]) buf[14])[0] = rslt.getString(13, 20) ;
                ((String[]) buf[15])[0] = rslt.getString(14, 50) ;
                ((String[]) buf[16])[0] = rslt.getString(15, 15) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                stmt.SetParameter(5, (DateTime)parms[5]);
                stmt.SetParameter(6, (String)parms[6]);
                stmt.SetParameter(7, (String)parms[7]);
                stmt.SetParameter(8, (int)parms[8]);
                stmt.SetParameter(9, (String)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[11]);
                }
                stmt.SetParameter(11, (String)parms[12]);
                stmt.SetParameter(12, (long)parms[13]);
                stmt.SetParameter(13, (short)parms[14]);
                stmt.SetParameter(14, (DateTime)parms[15]);
                stmt.SetParameter(15, (short)parms[16]);
                break;
       }
    }

 }

}
