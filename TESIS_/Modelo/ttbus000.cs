/*
               File: TTBUS000
        Description: Bienes de Uso (Trazabilidad)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:9.79
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ttbus000 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action13") == 0 )
         {
            A11TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A37TTBUS_CodPosicion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_13_011( A11TTBUS_Id, A37TTBUS_CodPosicion) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action16") == 0 )
         {
            A37TTBUS_CodPosicion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            Gx_mode = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            AV51USUARIO = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51USUARIO", AV51USUARIO);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_16_011( A37TTBUS_CodPosicion, Gx_mode, AV51USUARIO) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action21") == 0 )
         {
            A11TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A14IdIdentificador = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
            A15NumeroIdentificador = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
            Gx_mode = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_21_012( A11TTBUS_Id, A14IdIdentificador, A15NumeroIdentificador, Gx_mode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS_DESCRIPCION") == 0 )
         {
            A12TTBUS_Descripcion = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXSGATTBUS_DESCRIPCION010( A12TTBUS_Descripcion) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"IDIDENTIFICADOR") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLAIDIDENTIFICADOR012( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_28") == 0 )
         {
            A27TTBUS_CodProveedor = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n27TTBUS_CodProveedor = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_28( A27TTBUS_CodProveedor) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_29") == 0 )
         {
            A37TTBUS_CodPosicion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_29( A37TTBUS_CodPosicion) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_30") == 0 )
         {
            A17TTBUS_RubroBien = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_30( A17TTBUS_RubroBien) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_32") == 0 )
         {
            A14IdIdentificador = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_32( A14IdIdentificador) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridttbus000_identificadores") == 0 )
         {
            nRC_Gridttbus000_identificadores = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_109_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_109_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridttbus000_identificadores_newrow( nRC_Gridttbus000_identificadores, nGXsfl_109_idx, sGXsfl_109_idx) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridttbus000_documentacion") == 0 )
         {
            nRC_Gridttbus000_documentacion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_118_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_118_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridttbus000_documentacion_newrow( nRC_Gridttbus000_documentacion, nGXsfl_118_idx, sGXsfl_118_idx) ;
            return  ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( ! entryPointCalled )
         {
            AV39TTBUS_Id = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39TTBUS_Id), 8, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV34TTBUS_CodPosicion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_CodPosicion), 3, 0)));
               AV28pSEC_CRE = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28pSEC_CRE", AV28pSEC_CRE);
               AV38TTBUS_Estado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TTBUS_Estado", StringUtil.Str( (decimal)(AV38TTBUS_Estado), 1, 0));
               AV16consulta = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16consulta", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16consulta), 4, 0)));
               AV32SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32SISTEMA", AV32SISTEMA);
               AV51USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51USUARIO", AV51USUARIO);
            }
         }
         chkTTBUS_Alquilado.Name = "TTBUS_ALQUILADO" ;
         chkTTBUS_Alquilado.WebTags = "" ;
         chkTTBUS_Alquilado.Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
         chkTTBUS_Alquilado.CheckedValue = "0" ;
         GXCCtl = "IDIDENTIFICADOR_" + sGXsfl_109_idx ;
         dynIdIdentificador.Name = GXCCtl ;
         dynIdIdentificador.WebTags = "" ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Bienes de Uso (Trazabilidad)", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS_Descripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus000( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS_Id ,
                           ref String aP1_Gx_mode ,
                           ref short aP2_TTBUS_CodPosicion ,
                           ref String aP3_pSEC_CRE ,
                           ref short aP4_TTBUS_Estado ,
                           ref short aP5_consulta ,
                           ref String aP6_SISTEMA ,
                           ref String aP7_USUARIO )
      {
         this.AV39TTBUS_Id = aP0_TTBUS_Id;
         this.Gx_mode = aP1_Gx_mode;
         this.AV34TTBUS_CodPosicion = aP2_TTBUS_CodPosicion;
         this.AV28pSEC_CRE = aP3_pSEC_CRE;
         this.AV38TTBUS_Estado = aP4_TTBUS_Estado;
         this.AV16consulta = aP5_consulta;
         this.AV32SISTEMA = aP6_SISTEMA;
         this.AV51USUARIO = aP7_USUARIO;
         executePrivate();
         aP0_TTBUS_Id=this.AV39TTBUS_Id;
         aP1_Gx_mode=this.Gx_mode;
         aP2_TTBUS_CodPosicion=this.AV34TTBUS_CodPosicion;
         aP3_pSEC_CRE=this.AV28pSEC_CRE;
         aP4_TTBUS_Estado=this.AV38TTBUS_Estado;
         aP5_consulta=this.AV16consulta;
         aP6_SISTEMA=this.AV32SISTEMA;
         aP7_USUARIO=this.AV51USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkTTBUS_Alquilado = new GXCheckbox();
         dynIdIdentificador = new GXCombobox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_011( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_011e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_011( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_011( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_011e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Bienes de Uso (Trazabilidad)"+"</legend>") ;
            wb_table3_13_011( true) ;
         }
         return  ;
      }

      protected void wb_table3_13_011e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_011e( true) ;
         }
         else
         {
            wb_table1_2_011e( false) ;
         }
      }

      protected void wb_table3_13_011( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_19_011( true) ;
         }
         return  ;
      }

      protected void wb_table4_19_011e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "&nbsp; ") ;
            wb_table5_124_011( true) ;
         }
         return  ;
      }

      protected void wb_table5_124_011e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_13_011e( true) ;
         }
         else
         {
            wb_table3_13_011e( false) ;
         }
      }

      protected void wb_table5_124_011( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable7_Internalname, tblTable7_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 131,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 5, bttBtn_cancel_Jsonclick, "E\\'CANCELAR\\'.", TempTags, "", "", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_124_011e( true) ;
         }
         else
         {
            wb_table5_124_011e( false) ;
         }
      }

      protected void wb_table4_19_011( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(646), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(852), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_descripcion2_Internalname, 1, 1, 0, "CÓD:", "", "", "", 0, lblTextblockttbus_descripcion2_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_Id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtTTBUS_Id_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"), "", 0, edtTTBUS_Id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_descripcion_Internalname, 1, 1, 0, "DESCRIPCIÓN:", "", "", "", 0, lblTextblockttbus_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_Descripcion_Internalname, StringUtil.RTrim( A12TTBUS_Descripcion), "", 50, "chr", 1, "row", 50, 1, edtTTBUS_Descripcion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(29);\"", 0, edtTTBUS_Descripcion_Jsonclick, "", 0, 1, 0, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, 1, 1, 0, "Nº DE SERIE:", "", "", "", 0, lblTextblock10_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_NroSerie_Internalname, StringUtil.RTrim( A42TTBUS_NroSerie), "", 20, "chr", 1, "row", 20, 1, edtTTBUS_NroSerie_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A42TTBUS_NroSerie, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtTTBUS_NroSerie_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_fechacarga_Internalname, 1, 1, 0, "FECHA DE CARGA:", "", "", "", 0, lblTextblockttbus_fechacarga_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS_FechaCarga_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_FechaCarga_Internalname, context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtTTBUS_FechaCarga_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"), "", 0, edtTTBUS_FechaCarga_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS000.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS_FechaCarga_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS_FechaCarga_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_fechacarga2_Internalname, 1, 1, 0, "PROVEEDOR:", "", "", "", 0, lblTextblockttbus_fechacarga2_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_CodProveedor_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtTTBUS_CodProveedor_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A27TTBUS_CodProveedor), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"", 0, edtTTBUS_CodProveedor_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS000.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_27_Internalname, "", "prompt.gif", "Modern", imgprompt_27_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_27_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS000.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_DesProveedor_Internalname, StringUtil.RTrim( A30TTBUS_DesProveedor), "", 30, "chr", 1, "row", 30, 1, edtTTBUS_DesProveedor_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtTTBUS_DesProveedor_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_fechacarga5_Internalname, 1, 1, 0, "RUBRO:", "", "", "", 0, lblTextblockttbus_fechacarga5_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_RubroBien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17TTBUS_RubroBien), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtTTBUS_RubroBien_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A17TTBUS_RubroBien), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(50);\"", 0, edtTTBUS_RubroBien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS000.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_17_Internalname, "", "prompt.gif", "Modern", imgprompt_17_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_17_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS000.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_RubroDesc_Internalname, StringUtil.RTrim( A18TTBUS_RubroDesc), "", 30, "chr", 1, "row", 30, 1, edtTTBUS_RubroDesc_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A18TTBUS_RubroDesc, "@!")), "", 0, edtTTBUS_RubroDesc_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_fechacarga4_Internalname, 1, 1, 0, "ALQUILADO:", "", "", "", 0, lblTextblockttbus_fechacarga4_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkTTBUS_Alquilado_Internalname, StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0), "", 1, chkTTBUS_Alquilado.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(56, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(56);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"height:27px\">") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitleidentificadores2_Internalname, 1, 1, 0, "Ubicación Actual", "", "", "", 0, lblTitleidentificadores2_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"top\" >") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, 1, 1, 0, "POSICIÓN ACTUAL:", "", "", "", 0, lblTextblock14_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_CodPosicion_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtTTBUS_CodPosicion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A37TTBUS_CodPosicion), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(71);\"", 0, edtTTBUS_CodPosicion_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS000.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_37_Internalname, "", "prompt.gif", "Modern", imgprompt_37_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_37_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS000.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_DesPosicion_Internalname, StringUtil.RTrim( A38TTBUS_DesPosicion), "", 50, "chr", 1, "row", 50, 1, edtTTBUS_DesPosicion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtTTBUS_DesPosicion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, 1, 1, 0, "RESPONSABLE POSICIÓN ACTUAL:", "", "", "", 0, lblTextblock11_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavSec_dre_Internalname, StringUtil.RTrim( AV30SEC_DRE), "", 50, "chr", 1, "row", 50, 1, edtavSec_dre_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV30SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtavSec_dre_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, 1, 1, 0, "MOTIVO CAMBIO UBICACIÓN:", "", "", "", 0, lblTextblock12_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus2_motivoenvio_Internalname, StringUtil.RTrim( AV49TTBUS2_MotivoEnvio), "", 80, "chr", 1, "row", 100, 1, edtavTtbus2_motivoenvio_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV49TTBUS2_MotivoEnvio, "@!")), "", 0, edtavTtbus2_motivoenvio_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:21px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock16_Internalname, 1, 1, 0, "PLAZO DE RECEPCIÓN DEL BIEN:", "", "", "", 0, lblTextblock16_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavTtbus2_plazorecepcion_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus2_plazorecepcion_Internalname, context.localUtil.Format(AV52TTBUS2_PlazoRecepcion, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtavTtbus2_plazorecepcion_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV52TTBUS2_PlazoRecepcion, "99/99/9999"), "", 0, edtavTtbus2_plazorecepcion_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS000.htm");
            GxWebStd.gx_bitmap( context, edtavTtbus2_plazorecepcion_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtavTtbus2_plazorecepcion_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, 1, 1, 0, "OBSERVACIONES:", "", "", "", 0, lblTextblock13_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            ClassString = "Attribute" ;
            StyleString = "" ;
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            /* * Property isDeleted not supported in */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavTtbus2_observaciones_Internalname, StringUtil.RTrim( AV50TTBUS2_Observaciones), 1, edtavTtbus2_observaciones_Enabled, 1, 80, "chr", 5, "row", StyleString, ClassString, "400", "", -1, 0, "", "", true, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "USUARIO ALTA:", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_UsuarioAlta_Internalname, StringUtil.RTrim( A75TTBUS_UsuarioAlta), "", 15, "chr", 1, "row", 15, 1, edtTTBUS_UsuarioAlta_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A75TTBUS_UsuarioAlta, "XXXXXXXXXXXXXXX")), "", 0, edtTTBUS_UsuarioAlta_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "ESTACIÓN DE TRABAJO ALTA:", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_MaquinaAlta_Internalname, StringUtil.RTrim( A76TTBUS_MaquinaAlta), "", 20, "chr", 1, "row", 20, 1, edtTTBUS_MaquinaAlta_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A76TTBUS_MaquinaAlta, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtTTBUS_MaquinaAlta_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table6_105_011( true) ;
         }
         return  ;
      }

      protected void wb_table6_105_011e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridttbus000_identificadoresContainer.AddObjectProperty("GridName", "Gridttbus000_identificadores");
            Gridttbus000_identificadoresContainer.AddObjectProperty("Class", "Grid");
            Gridttbus000_identificadoresContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridttbus000_identificadoresContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridttbus000_identificadoresContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridttbus000_identificadores_Backcolorstyle), 1, 0, ".", "")));
            Gridttbus000_identificadoresContainer.AddObjectProperty("CmpContext", "");
            Gridttbus000_identificadoresContainer.AddObjectProperty("InMasterPage", "false");
            Gridttbus000_identificadoresColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus000_identificadoresColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ".", "")));
            Gridttbus000_identificadoresColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dynIdIdentificador.Enabled), 5, 0, ".", "")));
            Gridttbus000_identificadoresContainer.AddColumnProperties(Gridttbus000_identificadoresColumn);
            Gridttbus000_identificadoresColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus000_identificadoresColumn.AddObjectProperty("Value", StringUtil.RTrim( A15NumeroIdentificador));
            Gridttbus000_identificadoresColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtNumeroIdentificador_Enabled), 5, 0, ".", "")));
            Gridttbus000_identificadoresContainer.AddColumnProperties(Gridttbus000_identificadoresColumn);
            Gridttbus000_identificadoresContainer.AddObjectProperty("Allowselection", "false");
            Gridttbus000_identificadoresContainer.AddObjectProperty("Allowcollapsing", "false");
            Gridttbus000_identificadoresContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridttbus000_identificadores_Collapsed), 9, 0, ".", "")));
            nGXsfl_109_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount2 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_2 = 1 ;
                  ScanStart012( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     init_level_properties2( ) ;
                     getByPrimaryKey012( ) ;
                     AddRow012( ) ;
                     ScanNext012( ) ;
                  }
                  ScanEnd012( ) ;
                  nBlankRcdCount2 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               B74TTBUS_ContDocu = A74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
               standaloneNotModal012( ) ;
               standaloneModal012( ) ;
               sMode2 = Gx_mode ;
               while ( nGXsfl_109_idx < nRC_Gridttbus000_identificadores )
               {
                  ReadRow012( ) ;
                  dynIdIdentificador.Enabled = (int)(context.localUtil.CToN( cgiGet( "IDIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynIdIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynIdIdentificador.Enabled), 5, 0)));
                  edtNumeroIdentificador_Enabled = (int)(context.localUtil.CToN( cgiGet( "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNumeroIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNumeroIdentificador_Enabled), 5, 0)));
                  if ( ( nRcdExists_2 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal012( ) ;
                  }
                  SendRow012( ) ;
               }
               Gx_mode = sMode2 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               A74TTBUS_ContDocu = B74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount2 = 5 ;
               nRcdExists_2 = 1 ;
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  init_level_properties2( ) ;
                  getByPrimaryKey012( ) ;
                  standaloneNotModal012( ) ;
                  standaloneModal012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
            {
               sMode2 = Gx_mode ;
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               InitAll012( ) ;
               init_level_properties2( ) ;
               B74TTBUS_ContDocu = A74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
               standaloneNotModal012( ) ;
               standaloneModal012( ) ;
               nRcdExists_2 = 0 ;
               nIsMod_2 = 0 ;
               nBlankRcdCount2 = (short)(nBlankRcdUsr2+nBlankRcdCount2) ;
               fRowAdded = 0 ;
               while ( nBlankRcdCount2 > 0 )
               {
                  AddRow012( ) ;
                  if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
                  {
                     fRowAdded = 1 ;
                     GX_FocusControl = dynIdIdentificador_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  nBlankRcdCount2 = (short)(nBlankRcdCount2-1) ;
               }
               Gx_mode = sMode2 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               A74TTBUS_ContDocu = B74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            }
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridttbus000_identificadoresContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridttbus000_identificadores", (Object)(Gridttbus000_identificadoresContainer));
            GxWebStd.gx_hidden_field( context, "Gridttbus000_identificadoresContainerData", Gridttbus000_identificadoresContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridttbus000_identificadoresContainerData"+"V", Gridttbus000_identificadoresContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridttbus000_identificadoresContainerData"+"V"+"\" value='"+Gridttbus000_identificadoresContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table7_114_011( true) ;
         }
         return  ;
      }

      protected void wb_table7_114_011e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridttbus000_documentacionContainer.AddObjectProperty("GridName", "Gridttbus000_documentacion");
            Gridttbus000_documentacionContainer.AddObjectProperty("Class", "Grid");
            Gridttbus000_documentacionContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridttbus000_documentacionContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridttbus000_documentacionContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridttbus000_documentacion_Backcolorstyle), 1, 0, ".", "")));
            Gridttbus000_documentacionContainer.AddObjectProperty("CmpContext", "");
            Gridttbus000_documentacionContainer.AddObjectProperty("InMasterPage", "false");
            Gridttbus000_documentacionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus000_documentacionColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A64DocuId), 8, 0, ".", "")));
            Gridttbus000_documentacionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuId_Enabled), 5, 0, ".", "")));
            Gridttbus000_documentacionContainer.AddColumnProperties(Gridttbus000_documentacionColumn);
            Gridttbus000_documentacionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus000_documentacionColumn.AddObjectProperty("Value", StringUtil.RTrim( A65DocuDesc));
            Gridttbus000_documentacionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuDesc_Enabled), 5, 0, ".", "")));
            Gridttbus000_documentacionContainer.AddColumnProperties(Gridttbus000_documentacionColumn);
            Gridttbus000_documentacionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus000_documentacionColumn.AddObjectProperty("Value", StringUtil.RTrim( A66DocuObservaciones));
            Gridttbus000_documentacionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuObservaciones_Enabled), 5, 0, ".", "")));
            Gridttbus000_documentacionContainer.AddColumnProperties(Gridttbus000_documentacionColumn);
            Gridttbus000_documentacionContainer.AddObjectProperty("Allowselection", "false");
            Gridttbus000_documentacionContainer.AddObjectProperty("Allowcollapsing", "false");
            Gridttbus000_documentacionContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridttbus000_documentacion_Collapsed), 9, 0, ".", "")));
            nGXsfl_118_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount3 = 3 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_3 = 1 ;
                  ScanStart013( ) ;
                  while ( RcdFound3 != 0 )
                  {
                     init_level_properties3( ) ;
                     getByPrimaryKey013( ) ;
                     AddRow013( ) ;
                     ScanNext013( ) ;
                  }
                  ScanEnd013( ) ;
                  nBlankRcdCount3 = 3 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               B74TTBUS_ContDocu = A74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
               standaloneNotModal013( ) ;
               standaloneModal013( ) ;
               sMode3 = Gx_mode ;
               while ( nGXsfl_118_idx < nRC_Gridttbus000_documentacion )
               {
                  ReadRow013( ) ;
                  edtDocuId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCUID_"+sGXsfl_118_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuId_Enabled), 5, 0)));
                  edtDocuDesc_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCUDESC_"+sGXsfl_118_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuDesc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuDesc_Enabled), 5, 0)));
                  edtDocuObservaciones_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCUOBSERVACIONES_"+sGXsfl_118_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuObservaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuObservaciones_Enabled), 5, 0)));
                  if ( ( nRcdExists_3 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal013( ) ;
                  }
                  SendRow013( ) ;
               }
               Gx_mode = sMode3 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               A74TTBUS_ContDocu = B74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount3 = 3 ;
               nRcdExists_3 = 1 ;
               ScanStart013( ) ;
               while ( RcdFound3 != 0 )
               {
                  init_level_properties3( ) ;
                  getByPrimaryKey013( ) ;
                  standaloneNotModal013( ) ;
                  standaloneModal013( ) ;
                  AddRow013( ) ;
                  ScanNext013( ) ;
               }
               ScanEnd013( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
            {
               sMode3 = Gx_mode ;
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               InitAll013( ) ;
               init_level_properties3( ) ;
               B74TTBUS_ContDocu = A74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
               standaloneNotModal013( ) ;
               standaloneModal013( ) ;
               nRcdExists_3 = 0 ;
               nIsMod_3 = 0 ;
               nBlankRcdCount3 = (short)(nBlankRcdUsr3+nBlankRcdCount3) ;
               fRowAdded = 0 ;
               while ( nBlankRcdCount3 > 0 )
               {
                  AddRow013( ) ;
                  if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
                  {
                     fRowAdded = 1 ;
                     GX_FocusControl = edtDocuDesc_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  nBlankRcdCount3 = (short)(nBlankRcdCount3-1) ;
               }
               Gx_mode = sMode3 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               A74TTBUS_ContDocu = B74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            }
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridttbus000_documentacionContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridttbus000_documentacion", (Object)(Gridttbus000_documentacionContainer));
            GxWebStd.gx_hidden_field( context, "Gridttbus000_documentacionContainerData", Gridttbus000_documentacionContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridttbus000_documentacionContainerData"+"V", Gridttbus000_documentacionContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridttbus000_documentacionContainerData"+"V"+"\" value='"+Gridttbus000_documentacionContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_19_011e( true) ;
         }
         else
         {
            wb_table4_19_011e( false) ;
         }
      }

      protected void wb_table7_114_011( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table95", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitledocumentacion_Internalname, 1, 1, 0, "Documentación", "", "", "", 0, lblTitledocumentacion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_114_011e( true) ;
         }
         else
         {
            wb_table7_114_011e( false) ;
         }
      }

      protected void wb_table6_105_011( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table95", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitleidentificadores_Internalname, 1, 1, 0, "Identificadores", "", "", "", 0, lblTitleidentificadores_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_105_011e( true) ;
         }
         else
         {
            wb_table6_105_011e( false) ;
         }
      }

      protected void wb_table2_5_011( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS000.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_011e( true) ;
         }
         else
         {
            wb_table2_5_011e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11012 */
         E11012 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A42TTBUS_NroSerie = cgiGet( edtTTBUS_NroSerie_Internalname) ;
               n42TTBUS_NroSerie = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42TTBUS_NroSerie", A42TTBUS_NroSerie);
               n42TTBUS_NroSerie = (String.IsNullOrEmpty(StringUtil.RTrim( A42TTBUS_NroSerie)) ? true : false) ;
               A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS_CodProveedor_Internalname), "ZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS_CODPROVEEDOR");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS_CodProveedor_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A27TTBUS_CodProveedor = 0 ;
                  n27TTBUS_CodProveedor = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               }
               else
               {
                  A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
                  n27TTBUS_CodProveedor = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               }
               n27TTBUS_CodProveedor = ((0==A27TTBUS_CodProveedor) ? true : false) ;
               A30TTBUS_DesProveedor = cgiGet( edtTTBUS_DesProveedor_Internalname) ;
               n30TTBUS_DesProveedor = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS_RubroBien_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS_RubroBien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS_RubroBien_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS_RUBROBIEN");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS_RubroBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A17TTBUS_RubroBien = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
               }
               else
               {
                  A17TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_RubroBien_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
               }
               A18TTBUS_RubroDesc = StringUtil.Upper( cgiGet( edtTTBUS_RubroDesc_Internalname)) ;
               n18TTBUS_RubroDesc = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               if ( ! context.localUtil.VCNumber( cgiGet( chkTTBUS_Alquilado_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS_ALQUILADO");
                  AnyError = 1 ;
                  GX_FocusControl = chkTTBUS_Alquilado_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A29TTBUS_Alquilado = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               }
               else
               {
                  A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS_CodPosicion_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS_CODPOSICION");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS_CodPosicion_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A37TTBUS_CodPosicion = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               }
               else
               {
                  A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               }
               A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               AV30SEC_DRE = cgiGet( edtavSec_dre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30SEC_DRE", AV30SEC_DRE);
               AV49TTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavTtbus2_motivoenvio_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TTBUS2_MotivoEnvio", AV49TTBUS2_MotivoEnvio);
               AV52TTBUS2_PlazoRecepcion = context.localUtil.CToD( cgiGet( edtavTtbus2_plazorecepcion_Internalname), 4) ;
               AV50TTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtavTtbus2_observaciones_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TTBUS2_Observaciones", AV50TTBUS2_Observaciones);
               A75TTBUS_UsuarioAlta = cgiGet( edtTTBUS_UsuarioAlta_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75TTBUS_UsuarioAlta", A75TTBUS_UsuarioAlta);
               A76TTBUS_MaquinaAlta = cgiGet( edtTTBUS_MaquinaAlta_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76TTBUS_MaquinaAlta", A76TTBUS_MaquinaAlta);
               /* Read saved values. */
               Z11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "Z11TTBUS_Id"), ",", ".")) ;
               Z13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( "Z13TTBUS_FechaCarga"), 0) ;
               Z38TTBUS_DesPosicion = cgiGet( "Z38TTBUS_DesPosicion") ;
               Z75TTBUS_UsuarioAlta = cgiGet( "Z75TTBUS_UsuarioAlta") ;
               Z76TTBUS_MaquinaAlta = cgiGet( "Z76TTBUS_MaquinaAlta") ;
               Z12TTBUS_Descripcion = cgiGet( "Z12TTBUS_Descripcion") ;
               Z23TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( "Z23TTBUS_Estado"), ",", ".")) ;
               Z29TTBUS_Alquilado = (short)(context.localUtil.CToN( cgiGet( "Z29TTBUS_Alquilado"), ",", ".")) ;
               Z74TTBUS_ContDocu = (int)(context.localUtil.CToN( cgiGet( "Z74TTBUS_ContDocu"), ",", ".")) ;
               Z42TTBUS_NroSerie = cgiGet( "Z42TTBUS_NroSerie") ;
               Z27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( "Z27TTBUS_CodProveedor"), ",", ".")) ;
               Z37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( "Z37TTBUS_CodPosicion"), ",", ".")) ;
               Z17TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( "Z17TTBUS_RubroBien"), ",", ".")) ;
               A23TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( "Z23TTBUS_Estado"), ",", ".")) ;
               A74TTBUS_ContDocu = (int)(context.localUtil.CToN( cgiGet( "Z74TTBUS_ContDocu"), ",", ".")) ;
               n74TTBUS_ContDocu = false ;
               O74TTBUS_ContDocu = (int)(context.localUtil.CToN( cgiGet( "O74TTBUS_ContDocu"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridttbus000_identificadores = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridttbus000_identificadores"), ",", ".")) ;
               nRC_Gridttbus000_documentacion = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridttbus000_documentacion"), ",", ".")) ;
               AV34TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( "vTTBUS_CODPOSICION"), ",", ".")) ;
               AV28pSEC_CRE = cgiGet( "vPSEC_CRE") ;
               AV38TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( "vTTBUS_ESTADO"), ",", ".")) ;
               AV16consulta = (short)(context.localUtil.CToN( cgiGet( "vCONSULTA"), ",", ".")) ;
               AV32SISTEMA = cgiGet( "vSISTEMA") ;
               AV39TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "vTTBUS_ID"), ",", ".")) ;
               AV18dup_cont = (short)(context.localUtil.CToN( cgiGet( "vDUP_CONT"), ",", ".")) ;
               AV19dup_hw = (short)(context.localUtil.CToN( cgiGet( "vDUP_HW"), ",", ".")) ;
               AV51USUARIO = cgiGet( "vUSUARIO") ;
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", ".")) ;
               A23TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( "TTBUS_ESTADO"), ",", ".")) ;
               AV29SEC_CRE = cgiGet( "vSEC_CRE") ;
               AV14cod_error = (short)(context.localUtil.CToN( cgiGet( "vCOD_ERROR"), ",", ".")) ;
               AV25mje_error = cgiGet( "vMJE_ERROR") ;
               A74TTBUS_ContDocu = (int)(context.localUtil.CToN( cgiGet( "TTBUS_CONTDOCU"), ",", ".")) ;
               Gx_mode = cgiGet( "vMODE") ;
               AV15cod_error1 = (short)(context.localUtil.CToN( cgiGet( "vCOD_ERROR1"), ",", ".")) ;
               AV26mje_error1 = cgiGet( "vMJE_ERROR1") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A11TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode1 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode1 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_010( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "TTBUS_ID");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               /* Check if conditions changed and reset current page numbers */
               /* Check if conditions changed and reset current page numbers */
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'CANCELAR'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12012 */
                           E12012 ();
                           nKeyPressed = 3 ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4) ;
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 25), "TTBUS_CODPOSICION.ISVALID") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "AFTER TRN") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'CANCELAR'") == 0 ) )
                        {
                           nGXsfl_109_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                           sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0") ;
                           dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_109_idx ;
                           edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx ;
                           dynIdIdentificador.Name = dynIdIdentificador_Internalname ;
                           dynIdIdentificador.CurrentValue = cgiGet( dynIdIdentificador_Internalname) ;
                           A14IdIdentificador = (int)(NumberUtil.Val( cgiGet( dynIdIdentificador_Internalname), ".")) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
                           A15NumeroIdentificador = cgiGet( edtNumeroIdentificador_Internalname) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
                           GXCCtl = "Z14IdIdentificador_" + sGXsfl_109_idx ;
                           Z14IdIdentificador = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
                           GXCCtl = "Z15NumeroIdentificador_" + sGXsfl_109_idx ;
                           Z15NumeroIdentificador = cgiGet( GXCCtl) ;
                           GXCCtl = "nRcdDeleted_2_" + sGXsfl_109_idx ;
                           nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
                           GXCCtl = "nRcdExists_2_" + sGXsfl_109_idx ;
                           nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
                           GXCCtl = "nIsMod_2_" + sGXsfl_109_idx ;
                           nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
                           GXCCtl = "vTTBUS_ID_" + sGXsfl_109_idx ;
                           AV39TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
                           GXCCtl = "vTTBUS_CODPOSICION_" + sGXsfl_109_idx ;
                           AV34TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
                           GXCCtl = "vPSEC_CRE_" + sGXsfl_109_idx ;
                           AV28pSEC_CRE = cgiGet( GXCCtl) ;
                           GXCCtl = "vTTBUS_ESTADO_" + sGXsfl_109_idx ;
                           AV38TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
                           GXCCtl = "vCONSULTA_" + sGXsfl_109_idx ;
                           AV16consulta = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
                           GXCCtl = "vSISTEMA_" + sGXsfl_109_idx ;
                           AV32SISTEMA = cgiGet( GXCCtl) ;
                           GXCCtl = "vUSUARIO_" + sGXsfl_109_idx ;
                           AV51USUARIO = cgiGet( GXCCtl) ;
                           sEvtType = StringUtil.Right( sEvt, 1) ;
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E11012 */
                                 E11012 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "TTBUS_CODPOSICION.ISVALID") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E13012 */
                                 E13012 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E14012 */
                                 E14012 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'CANCELAR'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E12012 */
                                 E12012 ();
                                 nKeyPressed = 3 ;
                              }
                           }
                           else
                           {
                           }
                        }
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: E14012 */
            E14012 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtTTBUS_Id_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_Id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_Id_Enabled), 5, 0)));
            edtTTBUS_Descripcion_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_Descripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_Descripcion_Enabled), 5, 0)));
            edtTTBUS_NroSerie_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_NroSerie_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_NroSerie_Enabled), 5, 0)));
            edtTTBUS_FechaCarga_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_FechaCarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_FechaCarga_Enabled), 5, 0)));
            edtTTBUS_CodProveedor_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_CodProveedor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_CodProveedor_Enabled), 5, 0)));
            edtTTBUS_DesProveedor_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_DesProveedor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_DesProveedor_Enabled), 5, 0)));
            edtTTBUS_RubroBien_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_RubroBien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_RubroBien_Enabled), 5, 0)));
            edtTTBUS_RubroDesc_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_RubroDesc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_RubroDesc_Enabled), 5, 0)));
            chkTTBUS_Alquilado.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkTTBUS_Alquilado.Enabled), 5, 0)));
            edtTTBUS_CodPosicion_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_CodPosicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_CodPosicion_Enabled), 5, 0)));
            edtTTBUS_DesPosicion_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_DesPosicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_DesPosicion_Enabled), 5, 0)));
            edtavSec_dre_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
            edtavTtbus2_motivoenvio_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_motivoenvio_Enabled), 5, 0)));
            edtavTtbus2_plazorecepcion_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_plazorecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_plazorecepcion_Enabled), 5, 0)));
            edtavTtbus2_observaciones_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_observaciones_Enabled), 5, 0)));
            edtTTBUS_UsuarioAlta_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_UsuarioAlta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_UsuarioAlta_Enabled), 5, 0)));
            edtTTBUS_MaquinaAlta_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MaquinaAlta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MaquinaAlta_Enabled), 5, 0)));
            dynIdIdentificador.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynIdIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynIdIdentificador.Enabled), 5, 0)));
            edtNumeroIdentificador_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNumeroIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNumeroIdentificador_Enabled), 5, 0)));
            edtDocuId_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuId_Enabled), 5, 0)));
            edtDocuDesc_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuDesc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuDesc_Enabled), 5, 0)));
            edtDocuObservaciones_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuObservaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuObservaciones_Enabled), 5, 0)));
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode1 = Gx_mode ;
            CONFIRM_012( ) ;
            if ( AnyError == 0 )
            {
               CONFIRM_013( ) ;
               if ( AnyError == 0 )
               {
                  /* Restore parent mode. */
                  Gx_mode = sMode1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  IsConfirmed = 1 ;
               }
            }
            /* Restore parent mode. */
            Gx_mode = sMode1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
      }

      protected void CONFIRM_013( )
      {
         s74TTBUS_ContDocu = O74TTBUS_ContDocu ;
         n74TTBUS_ContDocu = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
         nGXsfl_118_idx = 0 ;
         while ( nGXsfl_118_idx < nRC_Gridttbus000_documentacion )
         {
            ReadRow013( ) ;
            if ( ( nRcdExists_3 != 0 ) || ( nIsMod_3 != 0 ) )
            {
               GetKey013( ) ;
               if ( ( nRcdExists_3 == 0 ) && ( nRcdDeleted_3 == 0 ) )
               {
                  if ( RcdFound3 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate013( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable013( ) ;
                        CloseExtendedTableCursors013( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1 ;
                        }
                        O74TTBUS_ContDocu = A74TTBUS_ContDocu ;
                        n74TTBUS_ContDocu = false ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                  }
               }
               else
               {
                  if ( RcdFound3 != 0 )
                  {
                     if ( nRcdDeleted_3 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey013( ) ;
                        Load013( ) ;
                        BeforeValidate013( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls013( ) ;
                           O74TTBUS_ContDocu = A74TTBUS_ContDocu ;
                           n74TTBUS_ContDocu = false ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_3 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate013( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable013( ) ;
                              CloseExtendedTableCursors013( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1 ;
                              }
                              O74TTBUS_ContDocu = A74TTBUS_ContDocu ;
                              n74TTBUS_ContDocu = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_3 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            ChangePostValue( edtDocuId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A64DocuId), 8, 0, ",", ""))) ;
            ChangePostValue( edtDocuDesc_Internalname, StringUtil.RTrim( A65DocuDesc)) ;
            ChangePostValue( edtDocuObservaciones_Internalname, StringUtil.RTrim( A66DocuObservaciones)) ;
            ChangePostValue( "ZT_"+"Z64DocuId_"+sGXsfl_118_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z64DocuId), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z65DocuDesc_"+sGXsfl_118_idx, StringUtil.RTrim( Z65DocuDesc)) ;
            ChangePostValue( "ZT_"+"Z66DocuObservaciones_"+sGXsfl_118_idx, StringUtil.RTrim( Z66DocuObservaciones)) ;
            ChangePostValue( "nRcdDeleted_3_"+sGXsfl_118_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_3_"+sGXsfl_118_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_3_"+sGXsfl_118_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ",", ""))) ;
            if ( nIsMod_3 != 0 )
            {
               ChangePostValue( "DOCUID_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DOCUDESC_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuDesc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DOCUOBSERVACIONES_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuObservaciones_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O74TTBUS_ContDocu = s74TTBUS_ContDocu ;
         n74TTBUS_ContDocu = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_012( )
      {
         nGXsfl_109_idx = 0 ;
         while ( nGXsfl_109_idx < nRC_Gridttbus000_identificadores )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate012( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable012( ) ;
                        CloseExtendedTableCursors012( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1 ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = dynIdIdentificador_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( nRcdDeleted_2 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey012( ) ;
                        Load012( ) ;
                        BeforeValidate012( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls012( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_2 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate012( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable012( ) ;
                              CloseExtendedTableCursors012( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1 ;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = dynIdIdentificador_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( dynIdIdentificador_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ".", ""))) ;
            ChangePostValue( edtNumeroIdentificador_Internalname, StringUtil.RTrim( A15NumeroIdentificador)) ;
            ChangePostValue( "ZT_"+"Z14IdIdentificador_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14IdIdentificador), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z15NumeroIdentificador_"+sGXsfl_109_idx, StringUtil.RTrim( Z15NumeroIdentificador)) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "IDIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dynIdIdentificador.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtNumeroIdentificador_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption010( )
      {
      }

      protected void E11012( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV17Context) ;
         AV51USUARIO = AV17Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51USUARIO", AV51USUARIO);
         AV23id_docu = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23id_docu", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23id_docu), 4, 0)));
         edtavSec_dre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            edtavTtbus2_motivoenvio_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_motivoenvio_Enabled), 5, 0)));
            edtavTtbus2_observaciones_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_observaciones_Enabled), 5, 0)));
            edtavTtbus2_plazorecepcion_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_plazorecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_plazorecepcion_Enabled), 5, 0)));
            AV49TTBUS2_MotivoEnvio = "" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TTBUS2_MotivoEnvio", AV49TTBUS2_MotivoEnvio);
            AV50TTBUS2_Observaciones = "INGRESO DEL BIEN AL SISTEMA" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TTBUS2_Observaciones", AV50TTBUS2_Observaciones);
         }
         AV20estado = (short)(NumberUtil.Val( AV31SESION.Get("Estado"), ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20estado", StringUtil.Str( (decimal)(AV20estado), 1, 0));
         if ( AV20estado == 2 )
         {
            edtTTBUS_CodPosicion_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_CodPosicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_CodPosicion_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            AV7band = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7band", StringUtil.Str( (decimal)(AV7band), 1, 0));
            new pttbus000_6(context ).execute(  AV34TTBUS_CodPosicion, ref  AV7band,  AV51USUARIO) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_CodPosicion), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7band", StringUtil.Str( (decimal)(AV7band), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51USUARIO", AV51USUARIO);
            if ( AV7band == 0 )
            {
               edtTTBUS_CodPosicion_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_CodPosicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_CodPosicion_Enabled), 5, 0)));
            }
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
         }
      }

      protected void E13012( )
      {
         /* TTBUS_CodPosicion_Isvalid Routine */
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            if ( A37TTBUS_CodPosicion != AV34TTBUS_CodPosicion )
            {
               AV31SESION.Set("CambiaUbicacion", "1");
               edtavTtbus2_motivoenvio_Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_motivoenvio_Enabled), 5, 0)));
               edtavTtbus2_observaciones_Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_observaciones_Enabled), 5, 0)));
               edtavTtbus2_plazorecepcion_Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_plazorecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_plazorecepcion_Enabled), 5, 0)));
            }
            else
            {
               AV31SESION.Set("CambiaUbicacion", "0");
               edtavTtbus2_motivoenvio_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_motivoenvio_Enabled), 5, 0)));
               edtavTtbus2_observaciones_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_observaciones_Enabled), 5, 0)));
               edtavTtbus2_plazorecepcion_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_plazorecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_plazorecepcion_Enabled), 5, 0)));
            }
         }
      }

      protected void E14012( )
      {
         /* After Trn Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            AV47TTBUS2_FechaEnvio = DateTimeUtil.Now( ) ;
            AV48TTBUS2_FechaRecepcion = DateTimeUtil.Now( ) ;
            GXt_int7 = 2 ;
            GXt_char6 = "INS" ;
            new pttbus000_1(context ).execute( ref  A11TTBUS_Id, ref  AV34TTBUS_CodPosicion, ref  AV28pSEC_CRE, ref  AV47TTBUS2_FechaEnvio, ref  A37TTBUS_CodPosicion, ref  AV29SEC_CRE, ref  AV48TTBUS2_FechaRecepcion, ref  GXt_int7, ref  AV49TTBUS2_MotivoEnvio, ref  AV50TTBUS2_Observaciones, ref  GXt_char6, ref  AV51USUARIO, ref  AV52TTBUS2_PlazoRecepcion) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_CodPosicion), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28pSEC_CRE", AV28pSEC_CRE);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SEC_CRE", AV29SEC_CRE);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TTBUS2_MotivoEnvio", AV49TTBUS2_MotivoEnvio);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TTBUS2_Observaciones", AV50TTBUS2_Observaciones);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51USUARIO", AV51USUARIO);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            if ( ( ( ( NumberUtil.Val( AV31SESION.Get("CambiaUbicacion"), ".") ) == Convert.ToDecimal( 1 )) ) )
            {
               AV47TTBUS2_FechaEnvio = DateTimeUtil.Now( ) ;
               AV48TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
               GXt_int7 = 1 ;
               GXt_char6 = "UPD" ;
               new pttbus000_1(context ).execute( ref  A11TTBUS_Id, ref  AV34TTBUS_CodPosicion, ref  AV28pSEC_CRE, ref  AV47TTBUS2_FechaEnvio, ref  A37TTBUS_CodPosicion, ref  AV29SEC_CRE, ref  AV48TTBUS2_FechaRecepcion, ref  GXt_int7, ref  AV49TTBUS2_MotivoEnvio, ref  AV50TTBUS2_Observaciones, ref  GXt_char6, ref  AV51USUARIO, ref  AV52TTBUS2_PlazoRecepcion) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_CodPosicion), 3, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28pSEC_CRE", AV28pSEC_CRE);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SEC_CRE", AV29SEC_CRE);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TTBUS2_MotivoEnvio", AV49TTBUS2_MotivoEnvio);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TTBUS2_Observaciones", AV50TTBUS2_Observaciones);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51USUARIO", AV51USUARIO);
            }
         }
      }

      protected void E12012( )
      {
         /* 'Cancelar' Routine */
         if ( AV16consulta == 0 )
         {
            context.wjLoc = formatLink("htbus001_prev.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV32SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV51USUARIO)) ;
         }
         else if ( AV16consulta == 3 )
         {
            context.setWebReturnParms(new Object[] {(int)AV39TTBUS_Id,(String)Gx_mode,(short)AV34TTBUS_CodPosicion,(String)AV28pSEC_CRE,(short)AV38TTBUS_Estado,(short)AV16consulta,(String)AV32SISTEMA,(String)AV51USUARIO});
            context.nUserReturn = 1 ;
            pr_default.close(3);
            pr_default.close(4);
            returnInSub = true;
            if (true) return;
         }
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 27 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z13TTBUS_FechaCarga = T00018_A13TTBUS_FechaCarga[0] ;
               Z38TTBUS_DesPosicion = T00018_A38TTBUS_DesPosicion[0] ;
               Z75TTBUS_UsuarioAlta = T00018_A75TTBUS_UsuarioAlta[0] ;
               Z76TTBUS_MaquinaAlta = T00018_A76TTBUS_MaquinaAlta[0] ;
               Z12TTBUS_Descripcion = T00018_A12TTBUS_Descripcion[0] ;
               Z23TTBUS_Estado = T00018_A23TTBUS_Estado[0] ;
               Z29TTBUS_Alquilado = T00018_A29TTBUS_Alquilado[0] ;
               Z74TTBUS_ContDocu = T00018_A74TTBUS_ContDocu[0] ;
               Z42TTBUS_NroSerie = T00018_A42TTBUS_NroSerie[0] ;
               Z27TTBUS_CodProveedor = T00018_A27TTBUS_CodProveedor[0] ;
               Z37TTBUS_CodPosicion = T00018_A37TTBUS_CodPosicion[0] ;
               Z17TTBUS_RubroBien = T00018_A17TTBUS_RubroBien[0] ;
            }
            else
            {
               Z13TTBUS_FechaCarga = A13TTBUS_FechaCarga ;
               Z38TTBUS_DesPosicion = A38TTBUS_DesPosicion ;
               Z75TTBUS_UsuarioAlta = A75TTBUS_UsuarioAlta ;
               Z76TTBUS_MaquinaAlta = A76TTBUS_MaquinaAlta ;
               Z12TTBUS_Descripcion = A12TTBUS_Descripcion ;
               Z23TTBUS_Estado = A23TTBUS_Estado ;
               Z29TTBUS_Alquilado = A29TTBUS_Alquilado ;
               Z74TTBUS_ContDocu = A74TTBUS_ContDocu ;
               Z42TTBUS_NroSerie = A42TTBUS_NroSerie ;
               Z27TTBUS_CodProveedor = A27TTBUS_CodProveedor ;
               Z37TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
               Z17TTBUS_RubroBien = A17TTBUS_RubroBien ;
            }
         }
         if ( GX_JID == -27 )
         {
            Z11TTBUS_Id = A11TTBUS_Id ;
            Z13TTBUS_FechaCarga = A13TTBUS_FechaCarga ;
            Z38TTBUS_DesPosicion = A38TTBUS_DesPosicion ;
            Z75TTBUS_UsuarioAlta = A75TTBUS_UsuarioAlta ;
            Z76TTBUS_MaquinaAlta = A76TTBUS_MaquinaAlta ;
            Z12TTBUS_Descripcion = A12TTBUS_Descripcion ;
            Z23TTBUS_Estado = A23TTBUS_Estado ;
            Z29TTBUS_Alquilado = A29TTBUS_Alquilado ;
            Z74TTBUS_ContDocu = A74TTBUS_ContDocu ;
            Z42TTBUS_NroSerie = A42TTBUS_NroSerie ;
            Z27TTBUS_CodProveedor = A27TTBUS_CodProveedor ;
            Z37TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
            Z17TTBUS_RubroBien = A17TTBUS_RubroBien ;
            Z30TTBUS_DesProveedor = A30TTBUS_DesProveedor ;
            Z18TTBUS_RubroDesc = A18TTBUS_RubroDesc ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtTTBUS_Id_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_Id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_Id_Enabled), 5, 0)));
         edtTTBUS_FechaCarga_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_FechaCarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_FechaCarga_Enabled), 5, 0)));
         edtTTBUS_DesPosicion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_DesPosicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_DesPosicion_Enabled), 5, 0)));
         AV18dup_cont = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18dup_cont", StringUtil.Str( (decimal)(AV18dup_cont), 1, 0));
         AV19dup_hw = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19dup_hw", StringUtil.Str( (decimal)(AV19dup_hw), 1, 0));
         edtTTBUS_UsuarioAlta_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_UsuarioAlta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_UsuarioAlta_Enabled), 5, 0)));
         edtTTBUS_MaquinaAlta_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MaquinaAlta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MaquinaAlta_Enabled), 5, 0)));
         Gx_BScreen = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_27_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0150.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS_CODPROVEEDOR"+"'), id:'"+"TTBUS_CODPROVEEDOR"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");") ;
         imgprompt_17_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0110.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS_RUBROBIEN"+"'), id:'"+"TTBUS_RUBROBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");") ;
         edtTTBUS_Id_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_Id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_Id_Enabled), 5, 0)));
         edtTTBUS_FechaCarga_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_FechaCarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_FechaCarga_Enabled), 5, 0)));
         edtTTBUS_DesPosicion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_DesPosicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_DesPosicion_Enabled), 5, 0)));
         edtTTBUS_UsuarioAlta_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_UsuarioAlta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_UsuarioAlta_Enabled), 5, 0)));
         edtTTBUS_MaquinaAlta_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MaquinaAlta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MaquinaAlta_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A11TTBUS_Id = AV39TTBUS_Id ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         }
         imgprompt_37_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"httbus_prompt1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS_CODPOSICION"+"'), id:'"+"TTBUS_CODPOSICION"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS_DESPOSICION"+"'), id:'"+"TTBUS_DESPOSICION"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"vSEC_CRE"+"'), id:'"+"vSEC_CRE"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"vSEC_DRE"+"'), id:'"+"vSEC_DRE"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"'"+StringUtil.RTrim( AV51USUARIO)+"'"+","+"'"+StringUtil.RTrim( Gx_mode)+"'"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");") ;
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            A13TTBUS_FechaCarga = DateTimeUtil.Today( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            A76TTBUS_MaquinaAlta = GXUtil.WrkSt( context) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76TTBUS_MaquinaAlta", A76TTBUS_MaquinaAlta);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            A75TTBUS_UsuarioAlta = AV51USUARIO ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75TTBUS_UsuarioAlta", A75TTBUS_UsuarioAlta);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A23TTBUS_Estado) && ( Gx_BScreen == 0 ) )
         {
            A23TTBUS_Estado = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
         }
      }

      protected void Load011( )
      {
         /* Using cursor T000112 */
         pr_default.execute(10, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound1 = 1 ;
            A13TTBUS_FechaCarga = T000112_A13TTBUS_FechaCarga[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
            A38TTBUS_DesPosicion = T000112_A38TTBUS_DesPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            A75TTBUS_UsuarioAlta = T000112_A75TTBUS_UsuarioAlta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75TTBUS_UsuarioAlta", A75TTBUS_UsuarioAlta);
            A76TTBUS_MaquinaAlta = T000112_A76TTBUS_MaquinaAlta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76TTBUS_MaquinaAlta", A76TTBUS_MaquinaAlta);
            A12TTBUS_Descripcion = T000112_A12TTBUS_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A23TTBUS_Estado = T000112_A23TTBUS_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A30TTBUS_DesProveedor = T000112_A30TTBUS_DesProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
            n30TTBUS_DesProveedor = T000112_n30TTBUS_DesProveedor[0] ;
            A29TTBUS_Alquilado = T000112_A29TTBUS_Alquilado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A18TTBUS_RubroDesc = T000112_A18TTBUS_RubroDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
            n18TTBUS_RubroDesc = T000112_n18TTBUS_RubroDesc[0] ;
            A74TTBUS_ContDocu = T000112_A74TTBUS_ContDocu[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            n74TTBUS_ContDocu = T000112_n74TTBUS_ContDocu[0] ;
            A42TTBUS_NroSerie = T000112_A42TTBUS_NroSerie[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42TTBUS_NroSerie", A42TTBUS_NroSerie);
            n42TTBUS_NroSerie = T000112_n42TTBUS_NroSerie[0] ;
            A27TTBUS_CodProveedor = T000112_A27TTBUS_CodProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
            n27TTBUS_CodProveedor = T000112_n27TTBUS_CodProveedor[0] ;
            A37TTBUS_CodPosicion = T000112_A37TTBUS_CodPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A17TTBUS_RubroBien = T000112_A17TTBUS_RubroBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
            ZM011( -27) ;
         }
         pr_default.close(10);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         new pttbus000_5(context ).execute(  A11TTBUS_Id,  A37TTBUS_CodPosicion, out  A38TTBUS_DesPosicion, out  AV29SEC_CRE, out  AV30SEC_DRE) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SEC_CRE", AV29SEC_CRE);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30SEC_DRE", AV30SEC_DRE);
         if ( ( StringUtil.StrCmp(StringUtil.Trim( A12TTBUS_Descripcion), "") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("DEBE INGRESAR UNA DESCRIPCIÓN PARA EL BIEN DE USO.", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {n27TTBUS_CodProveedor, A27TTBUS_CodProveedor});
         if ( (pr_default.getStatus(7) == 101) )
         {
            if ( ! ( (0==A27TTBUS_CodProveedor) ) )
            {
               GX_msglist.addItem("No existe 'Proveedor de bien de uso'.", "ForeignKeyNotFound", 1, "TTBUS_CODPROVEEDOR");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS_CodProveedor_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( AnyError == 0 )
         {
            A30TTBUS_DesProveedor = T00019_A30TTBUS_DesProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
            n30TTBUS_DesProveedor = T00019_n30TTBUS_DesProveedor[0] ;
         }
         pr_default.close(7);
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A37TTBUS_CodPosicion});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Posición de Bien de Uso'.", "ForeignKeyNotFound", 1, "TTBUS_CODPOSICION");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS_CodPosicion_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(8);
         if ( ( ( A37TTBUS_CodPosicion == 0 ) ) && true /* After */ )
         {
            GX_msglist.addItem("DEBE SELECCIONAR UNA POSICIÓN ACTUAL PARA EL BIEN.", 1, "");
            AnyError = 1 ;
         }
         if ( true /* After */ && ( A37TTBUS_CodPosicion != 999 ) )
         {
            new pttbus000_8(context ).execute(  A37TTBUS_CodPosicion,  Gx_mode,  AV51USUARIO, out  AV14cod_error, out  AV25mje_error) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51USUARIO", AV51USUARIO);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cod_error", StringUtil.Str( (decimal)(AV14cod_error), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25mje_error", AV25mje_error);
         }
         if ( true /* After */ && ( AV14cod_error == 1 ) && ( A37TTBUS_CodPosicion != 999 ) )
         {
            GX_msglist.addItem(StringUtil.Trim( AV25mje_error), 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T000111 */
         pr_default.execute(9, new Object[] {A17TTBUS_RubroBien});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'Rubro de bien de uso'.", "ForeignKeyNotFound", 1, "TTBUS_RUBROBIEN");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS_RubroBien_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A18TTBUS_RubroDesc = T000111_A18TTBUS_RubroDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
            n18TTBUS_RubroDesc = T000111_n18TTBUS_RubroDesc[0] ;
         }
         pr_default.close(9);
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(7);
         pr_default.close(8);
         pr_default.close(9);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_28( int A27TTBUS_CodProveedor )
      {
         /* Using cursor T000113 */
         pr_default.execute(11, new Object[] {n27TTBUS_CodProveedor, A27TTBUS_CodProveedor});
         if ( (pr_default.getStatus(11) == 101) )
         {
            if ( ! ( (0==A27TTBUS_CodProveedor) ) )
            {
               GX_msglist.addItem("No existe 'Proveedor de bien de uso'.", "ForeignKeyNotFound", 1, "TTBUS_CODPROVEEDOR");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS_CodProveedor_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( AnyError == 0 )
         {
            A30TTBUS_DesProveedor = T000113_A30TTBUS_DesProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
            n30TTBUS_DesProveedor = T000113_n30TTBUS_DesProveedor[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A30TTBUS_DesProveedor))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(11);
      }

      protected void gxLoad_29( short A37TTBUS_CodPosicion )
      {
         /* Using cursor T000114 */
         pr_default.execute(12, new Object[] {A37TTBUS_CodPosicion});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'Posición de Bien de Uso'.", "ForeignKeyNotFound", 1, "TTBUS_CODPOSICION");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS_CodPosicion_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(12);
      }

      protected void gxLoad_30( short A17TTBUS_RubroBien )
      {
         /* Using cursor T000115 */
         pr_default.execute(13, new Object[] {A17TTBUS_RubroBien});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Rubro de bien de uso'.", "ForeignKeyNotFound", 1, "TTBUS_RUBROBIEN");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS_RubroBien_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A18TTBUS_RubroDesc = T000115_A18TTBUS_RubroDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
            n18TTBUS_RubroDesc = T000115_n18TTBUS_RubroDesc[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A18TTBUS_RubroDesc))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(13) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(13);
      }

      protected void GetKey011( )
      {
         /* Using cursor T000116 */
         pr_default.execute(14, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1 ;
         }
         else
         {
            RcdFound1 = 0 ;
         }
         pr_default.close(14);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(6) != 101) )
         {
            ZM011( 27) ;
            RcdFound1 = 1 ;
            A11TTBUS_Id = T00018_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A13TTBUS_FechaCarga = T00018_A13TTBUS_FechaCarga[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
            A38TTBUS_DesPosicion = T00018_A38TTBUS_DesPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            A75TTBUS_UsuarioAlta = T00018_A75TTBUS_UsuarioAlta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75TTBUS_UsuarioAlta", A75TTBUS_UsuarioAlta);
            A76TTBUS_MaquinaAlta = T00018_A76TTBUS_MaquinaAlta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76TTBUS_MaquinaAlta", A76TTBUS_MaquinaAlta);
            A12TTBUS_Descripcion = T00018_A12TTBUS_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A23TTBUS_Estado = T00018_A23TTBUS_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A29TTBUS_Alquilado = T00018_A29TTBUS_Alquilado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A74TTBUS_ContDocu = T00018_A74TTBUS_ContDocu[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            n74TTBUS_ContDocu = T00018_n74TTBUS_ContDocu[0] ;
            A42TTBUS_NroSerie = T00018_A42TTBUS_NroSerie[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42TTBUS_NroSerie", A42TTBUS_NroSerie);
            n42TTBUS_NroSerie = T00018_n42TTBUS_NroSerie[0] ;
            A27TTBUS_CodProveedor = T00018_A27TTBUS_CodProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
            n27TTBUS_CodProveedor = T00018_n27TTBUS_CodProveedor[0] ;
            A37TTBUS_CodPosicion = T00018_A37TTBUS_CodPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A17TTBUS_RubroBien = T00018_A17TTBUS_RubroBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
            O74TTBUS_ContDocu = A74TTBUS_ContDocu ;
            n74TTBUS_ContDocu = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            Z11TTBUS_Id = A11TTBUS_Id ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load011( ) ;
            Gx_mode = sMode1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound1 = 0 ;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(6);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T000117 */
         pr_default.execute(15, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( T000117_A11TTBUS_Id[0] < A11TTBUS_Id ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( T000117_A11TTBUS_Id[0] > A11TTBUS_Id ) ) )
            {
               A11TTBUS_Id = T000117_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T000118 */
         pr_default.execute(16, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(16) != 101) )
         {
            while ( (pr_default.getStatus(16) != 101) && ( ( T000118_A11TTBUS_Id[0] > A11TTBUS_Id ) ) )
            {
               pr_default.readNext(16);
            }
            if ( (pr_default.getStatus(16) != 101) && ( ( T000118_A11TTBUS_Id[0] < A11TTBUS_Id ) ) )
            {
               A11TTBUS_Id = T000118_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey011( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS_ID");
               AnyError = 1 ;
            }
            else if ( A11TTBUS_Id != Z11TTBUS_Id )
            {
               A11TTBUS_Id = Z11TTBUS_Id ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "TTBUS_ID");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               A74TTBUS_ContDocu = O74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS_Descripcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               A74TTBUS_ContDocu = O74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
               Update011( ) ;
               GX_FocusControl = edtTTBUS_Descripcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A11TTBUS_Id != Z11TTBUS_Id )
            {
               /* Insert record */
               A74TTBUS_ContDocu = O74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
               Insert011( ) ;
               GX_FocusControl = edtTTBUS_Descripcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "TTBUS_ID");
                  AnyError = 1 ;
               }
               else
               {
                  /* Insert record */
                  A74TTBUS_ContDocu = O74TTBUS_ContDocu ;
                  n74TTBUS_ContDocu = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
                  Insert011( ) ;
                  GX_FocusControl = edtTTBUS_Descripcion_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A11TTBUS_Id != Z11TTBUS_Id )
         {
            A11TTBUS_Id = Z11TTBUS_Id ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "TTBUS_ID");
            AnyError = 1 ;
         }
         else
         {
            A74TTBUS_ContDocu = O74TTBUS_ContDocu ;
            n74TTBUS_ContDocu = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS_Descripcion_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000119 */
            pr_default.execute(17, new Object[] {A11TTBUS_Id});
            if ( (pr_default.getStatus(17) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS000"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(17) == 101) || ( Z13TTBUS_FechaCarga != T000119_A13TTBUS_FechaCarga[0] ) || ( StringUtil.StrCmp(Z38TTBUS_DesPosicion, T000119_A38TTBUS_DesPosicion[0]) != 0 ) || ( StringUtil.StrCmp(Z75TTBUS_UsuarioAlta, T000119_A75TTBUS_UsuarioAlta[0]) != 0 ) || ( StringUtil.StrCmp(Z76TTBUS_MaquinaAlta, T000119_A76TTBUS_MaquinaAlta[0]) != 0 ) || ( StringUtil.StrCmp(Z12TTBUS_Descripcion, T000119_A12TTBUS_Descripcion[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z23TTBUS_Estado != T000119_A23TTBUS_Estado[0] ) || ( Z29TTBUS_Alquilado != T000119_A29TTBUS_Alquilado[0] ) || ( Z74TTBUS_ContDocu != T000119_A74TTBUS_ContDocu[0] ) || ( StringUtil.StrCmp(Z42TTBUS_NroSerie, T000119_A42TTBUS_NroSerie[0]) != 0 ) || ( Z27TTBUS_CodProveedor != T000119_A27TTBUS_CodProveedor[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z37TTBUS_CodPosicion != T000119_A37TTBUS_CodPosicion[0] ) || ( Z17TTBUS_RubroBien != T000119_A17TTBUS_RubroBien[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS000"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000120 */
                     pr_default.execute(18, new Object[] {A13TTBUS_FechaCarga, A38TTBUS_DesPosicion, A75TTBUS_UsuarioAlta, A76TTBUS_MaquinaAlta, A12TTBUS_Descripcion, A23TTBUS_Estado, A29TTBUS_Alquilado, n74TTBUS_ContDocu, A74TTBUS_ContDocu, n42TTBUS_NroSerie, A42TTBUS_NroSerie, n27TTBUS_CodProveedor, A27TTBUS_CodProveedor, A37TTBUS_CodPosicion, A17TTBUS_RubroBien});
                     pr_default.close(18);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000121 */
                     pr_default.execute(19);
                     A11TTBUS_Id = T000121_A11TTBUS_Id[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                     pr_default.close(19);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                              ResetCaption010( ) ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000122 */
                     pr_default.execute(20, new Object[] {A13TTBUS_FechaCarga, A38TTBUS_DesPosicion, A75TTBUS_UsuarioAlta, A76TTBUS_MaquinaAlta, A12TTBUS_Descripcion, A23TTBUS_Estado, A29TTBUS_Alquilado, n74TTBUS_ContDocu, A74TTBUS_ContDocu, n42TTBUS_NroSerie, A42TTBUS_NroSerie, n27TTBUS_CodProveedor, A27TTBUS_CodProveedor, A37TTBUS_CodPosicion, A17TTBUS_RubroBien, A11TTBUS_Id});
                     pr_default.close(20);
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS000"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate011( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                              {
                                 if ( AnyError == 0 )
                                 {
                                    context.nUserReturn = 1 ;
                                 }
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  A74TTBUS_ContDocu = O74TTBUS_ContDocu ;
                  n74TTBUS_ContDocu = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
                  ScanStart013( ) ;
                  while ( RcdFound3 != 0 )
                  {
                     getByPrimaryKey013( ) ;
                     Delete013( ) ;
                     ScanNext013( ) ;
                     O74TTBUS_ContDocu = A74TTBUS_ContDocu ;
                     n74TTBUS_ContDocu = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
                  }
                  ScanEnd013( ) ;
                  ScanStart012( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     getByPrimaryKey012( ) ;
                     Delete012( ) ;
                     ScanNext012( ) ;
                  }
                  ScanEnd012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000123 */
                     pr_default.execute(21, new Object[] {A11TTBUS_Id});
                     pr_default.close(21);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
         sMode1 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel011( ) ;
         Gx_mode = sMode1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000124 */
            pr_default.execute(22, new Object[] {n27TTBUS_CodProveedor, A27TTBUS_CodProveedor});
            A30TTBUS_DesProveedor = T000124_A30TTBUS_DesProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
            n30TTBUS_DesProveedor = T000124_n30TTBUS_DesProveedor[0] ;
            pr_default.close(22);
            /* Using cursor T000125 */
            pr_default.execute(23, new Object[] {A17TTBUS_RubroBien});
            A18TTBUS_RubroDesc = T000125_A18TTBUS_RubroDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
            n18TTBUS_RubroDesc = T000125_n18TTBUS_RubroDesc[0] ;
            pr_default.close(23);
         }
      }

      protected void ProcessNestedLevel012( )
      {
         nGXsfl_109_idx = 0 ;
         while ( nGXsfl_109_idx < nRC_Gridttbus000_identificadores )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               standaloneNotModal012( ) ;
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert012( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = dynIdIdentificador_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( ( nRcdDeleted_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete012( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update012( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = dynIdIdentificador_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( dynIdIdentificador_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ".", ""))) ;
            ChangePostValue( edtNumeroIdentificador_Internalname, StringUtil.RTrim( A15NumeroIdentificador)) ;
            ChangePostValue( "ZT_"+"Z14IdIdentificador_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14IdIdentificador), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z15NumeroIdentificador_"+sGXsfl_109_idx, StringUtil.RTrim( Z15NumeroIdentificador)) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "IDIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dynIdIdentificador.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtNumeroIdentificador_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll012( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_2 = 0 ;
         nIsMod_2 = 0 ;
         nRcdDeleted_2 = 0 ;
      }

      protected void ProcessNestedLevel013( )
      {
         s74TTBUS_ContDocu = O74TTBUS_ContDocu ;
         n74TTBUS_ContDocu = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
         nGXsfl_118_idx = 0 ;
         while ( nGXsfl_118_idx < nRC_Gridttbus000_documentacion )
         {
            ReadRow013( ) ;
            if ( ( nRcdExists_3 != 0 ) || ( nIsMod_3 != 0 ) )
            {
               standaloneNotModal013( ) ;
               GetKey013( ) ;
               if ( ( nRcdExists_3 == 0 ) && ( nRcdDeleted_3 == 0 ) )
               {
                  if ( RcdFound3 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert013( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                  }
               }
               else
               {
                  if ( RcdFound3 != 0 )
                  {
                     if ( ( nRcdDeleted_3 != 0 ) && ( nRcdExists_3 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete013( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_3 != 0 ) && ( nRcdExists_3 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update013( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_3 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
               O74TTBUS_ContDocu = A74TTBUS_ContDocu ;
               n74TTBUS_ContDocu = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
            }
            ChangePostValue( edtDocuId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A64DocuId), 8, 0, ",", ""))) ;
            ChangePostValue( edtDocuDesc_Internalname, StringUtil.RTrim( A65DocuDesc)) ;
            ChangePostValue( edtDocuObservaciones_Internalname, StringUtil.RTrim( A66DocuObservaciones)) ;
            ChangePostValue( "ZT_"+"Z64DocuId_"+sGXsfl_118_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z64DocuId), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z65DocuDesc_"+sGXsfl_118_idx, StringUtil.RTrim( Z65DocuDesc)) ;
            ChangePostValue( "ZT_"+"Z66DocuObservaciones_"+sGXsfl_118_idx, StringUtil.RTrim( Z66DocuObservaciones)) ;
            ChangePostValue( "nRcdDeleted_3_"+sGXsfl_118_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_3_"+sGXsfl_118_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_3_"+sGXsfl_118_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ",", ""))) ;
            if ( nIsMod_3 != 0 )
            {
               ChangePostValue( "DOCUID_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DOCUDESC_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuDesc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DOCUOBSERVACIONES_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuObservaciones_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll013( ) ;
         if ( AnyError != 0 )
         {
            O74TTBUS_ContDocu = s74TTBUS_ContDocu ;
            n74TTBUS_ContDocu = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
         }
         nRcdExists_3 = 0 ;
         nIsMod_3 = 0 ;
         nRcdDeleted_3 = 0 ;
      }

      protected void ProcessLevel011( )
      {
         /* Save parent mode. */
         sMode1 = Gx_mode ;
         ProcessNestedLevel012( ) ;
         ProcessNestedLevel013( ) ;
         if ( AnyError != 0 )
         {
            O74TTBUS_ContDocu = s74TTBUS_ContDocu ;
            n74TTBUS_ContDocu = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
         /* Using cursor T000126 */
         pr_default.execute(24, new Object[] {n74TTBUS_ContDocu, A74TTBUS_ContDocu, A11TTBUS_Id});
         pr_default.close(24);
      }

      protected void EndLevel011( )
      {
         pr_default.close(17);
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(16);
            pr_default.close(15);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(22);
            pr_default.close(23);
            pr_default.close(4);
            context.CommitDataStores("TTBUS000");
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(16);
            pr_default.close(15);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(22);
            pr_default.close(23);
            pr_default.close(4);
            context.RollbackDataStores("TTBUS000");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart011( )
      {
         /* Using cursor T000127 */
         pr_default.execute(25);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound1 = 1 ;
            A11TTBUS_Id = T000127_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         pr_default.readNext(25);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound1 = 1 ;
            A11TTBUS_Id = T000127_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         }
      }

      protected void ScanEnd011( )
      {
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void ZM012( short GX_JID )
      {
         if ( ( GX_JID == 31 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z15NumeroIdentificador = T00015_A15NumeroIdentificador[0] ;
            }
            else
            {
               Z15NumeroIdentificador = A15NumeroIdentificador ;
            }
         }
         if ( GX_JID == -31 )
         {
            Z11TTBUS_Id = A11TTBUS_Id ;
            Z15NumeroIdentificador = A15NumeroIdentificador ;
            Z14IdIdentificador = A14IdIdentificador ;
         }
      }

      protected void standaloneNotModal012( )
      {
         GXAIDIDENTIFICADOR_html012( ) ;
      }

      protected void standaloneModal012( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            dynIdIdentificador.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynIdIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynIdIdentificador.Enabled), 5, 0)));
         }
         else
         {
            dynIdIdentificador.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynIdIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynIdIdentificador.Enabled), 5, 0)));
         }
      }

      protected void Load012( )
      {
         /* Using cursor T000128 */
         pr_default.execute(26, new Object[] {A11TTBUS_Id, A14IdIdentificador});
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound2 = 1 ;
            A15NumeroIdentificador = T000128_A15NumeroIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
            ZM012( -31) ;
         }
         pr_default.close(26);
         OnLoadActions012( ) ;
      }

      protected void OnLoadActions012( )
      {
      }

      protected void CheckExtendedTable012( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal012( ) ;
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A14IdIdentificador});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Identificador de Bien de Uso'.", "ForeignKeyNotFound", 1, "IDIDENTIFICADOR");
            AnyError = 1 ;
            GX_FocusControl = dynIdIdentificador_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(4);
         if ( ( ( A14IdIdentificador != 0 ) ) && ( StringUtil.StrCmp(StringUtil.Trim( A15NumeroIdentificador), "") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("DEBE INGRESAR UN CÓDIGO PARA EL IDENTIFICADOR SELECCIONADO.", 1, "");
            AnyError = 1 ;
         }
         if ( ( ( A14IdIdentificador == 0 ) ) && ! ( StringUtil.StrCmp(StringUtil.Trim( A15NumeroIdentificador), "") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("DEBE SELECCIONAR UN IDENTIFICADOR PARA EL CÓDIGO CARGADO.", 1, "");
            AnyError = 1 ;
         }
         if ( true /* After */ && ( ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) || ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) ) ) )
         {
            new pttbus000_10(context ).execute(  A11TTBUS_Id,  A14IdIdentificador,  A15NumeroIdentificador, out  AV15cod_error1, out  AV26mje_error1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cod_error1", StringUtil.Str( (decimal)(AV15cod_error1), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26mje_error1", AV26mje_error1);
         }
         if ( AV15cod_error1 == 1 )
         {
            GX_msglist.addItem(AV26mje_error1, 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors012( )
      {
         pr_default.close(4);
      }

      protected void enableDisable012( )
      {
      }

      protected void gxLoad_32( int A14IdIdentificador )
      {
         /* Using cursor T000129 */
         pr_default.execute(27, new Object[] {A14IdIdentificador});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GX_msglist.addItem("No existe 'Identificador de Bien de Uso'.", "ForeignKeyNotFound", 1, "IDIDENTIFICADOR");
            AnyError = 1 ;
            GX_FocusControl = dynIdIdentificador_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(27) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(27);
      }

      protected void GetKey012( )
      {
         /* Using cursor T000130 */
         pr_default.execute(28, new Object[] {A11TTBUS_Id, A14IdIdentificador});
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound2 = 1 ;
         }
         else
         {
            RcdFound2 = 0 ;
         }
         pr_default.close(28);
      }

      protected void getByPrimaryKey012( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A11TTBUS_Id, A14IdIdentificador});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM012( 31) ;
            RcdFound2 = 1 ;
            InitializeNonKey012( ) ;
            A15NumeroIdentificador = T00015_A15NumeroIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
            A14IdIdentificador = T00015_A14IdIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
            Z11TTBUS_Id = A11TTBUS_Id ;
            Z14IdIdentificador = A14IdIdentificador ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load012( ) ;
            Gx_mode = sMode2 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0 ;
            InitializeNonKey012( ) ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal012( ) ;
            Gx_mode = sMode2 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void CheckOptimisticConcurrency012( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A11TTBUS_Id, A14IdIdentificador});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS000Identificadores"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z15NumeroIdentificador, T00014_A15NumeroIdentificador[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS000Identificadores"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM012( 0) ;
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000131 */
                     pr_default.execute(29, new Object[] {A11TTBUS_Id, A15NumeroIdentificador, A14IdIdentificador});
                     pr_default.close(29);
                     if ( (pr_default.getStatus(29) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load012( ) ;
            }
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void Update012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000132 */
                     pr_default.execute(30, new Object[] {A15NumeroIdentificador, A11TTBUS_Id, A14IdIdentificador});
                     pr_default.close(30);
                     if ( (pr_default.getStatus(30) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS000Identificadores"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate012( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey012( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void DeferredUpdate012( )
      {
      }

      protected void Delete012( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls012( ) ;
            AfterConfirm012( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete012( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000133 */
                  pr_default.execute(31, new Object[] {A11TTBUS_Id, A14IdIdentificador});
                  pr_default.close(31);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode2 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel012( ) ;
         Gx_mode = sMode2 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls012( )
      {
         standaloneModal012( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel012( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart012( )
      {
         /* Using cursor T000134 */
         pr_default.execute(32, new Object[] {A11TTBUS_Id});
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(32) != 101) )
         {
            RcdFound2 = 1 ;
            A14IdIdentificador = T000134_A14IdIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext012( )
      {
         pr_default.readNext(32);
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(32) != 101) )
         {
            RcdFound2 = 1 ;
            A14IdIdentificador = T000134_A14IdIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
         }
      }

      protected void ScanEnd012( )
      {
         pr_default.close(3);
      }

      protected void AfterConfirm012( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert012( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate012( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete012( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete012( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate012( )
      {
         /* Before Validate Rules */
      }

      protected void ZM013( short GX_JID )
      {
         if ( ( GX_JID == 33 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z65DocuDesc = T00013_A65DocuDesc[0] ;
               Z66DocuObservaciones = T00013_A66DocuObservaciones[0] ;
            }
            else
            {
               Z65DocuDesc = A65DocuDesc ;
               Z66DocuObservaciones = A66DocuObservaciones ;
            }
         }
         if ( GX_JID == -33 )
         {
            Z11TTBUS_Id = A11TTBUS_Id ;
            Z64DocuId = A64DocuId ;
            Z65DocuDesc = A65DocuDesc ;
            Z66DocuObservaciones = A66DocuObservaciones ;
         }
      }

      protected void standaloneNotModal013( )
      {
         edtDocuId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuId_Enabled), 5, 0)));
      }

      protected void standaloneModal013( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A74TTBUS_ContDocu = (int)(O74TTBUS_ContDocu+1) ;
            n74TTBUS_ContDocu = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A64DocuId = A74TTBUS_ContDocu ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DocuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A64DocuId), 8, 0)));
         }
      }

      protected void Load013( )
      {
         /* Using cursor T000135 */
         pr_default.execute(33, new Object[] {A11TTBUS_Id, A64DocuId});
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound3 = 1 ;
            A65DocuDesc = T000135_A65DocuDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DocuDesc", A65DocuDesc);
            A66DocuObservaciones = T000135_A66DocuObservaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66DocuObservaciones", A66DocuObservaciones);
            ZM013( -33) ;
         }
         pr_default.close(33);
         OnLoadActions013( ) ;
      }

      protected void OnLoadActions013( )
      {
      }

      protected void CheckExtendedTable013( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal013( ) ;
         if ( ( ( StringUtil.StrCmp(StringUtil.Trim( A66DocuObservaciones), "") != 0 ) ) && ( ( StringUtil.StrCmp(StringUtil.Trim( A65DocuDesc), "") == 0 ) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("DEBE INGRESAR UNA DESCRIPCIÓN PARA LA OBSERVACIÓN CARGADA.", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors013( )
      {
      }

      protected void enableDisable013( )
      {
      }

      protected void GetKey013( )
      {
         /* Using cursor T000136 */
         pr_default.execute(34, new Object[] {A11TTBUS_Id, A64DocuId});
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound3 = 1 ;
         }
         else
         {
            RcdFound3 = 0 ;
         }
         pr_default.close(34);
      }

      protected void getByPrimaryKey013( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A11TTBUS_Id, A64DocuId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM013( 33) ;
            RcdFound3 = 1 ;
            InitializeNonKey013( ) ;
            A64DocuId = T00013_A64DocuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DocuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A64DocuId), 8, 0)));
            A65DocuDesc = T00013_A65DocuDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DocuDesc", A65DocuDesc);
            A66DocuObservaciones = T00013_A66DocuObservaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66DocuObservaciones", A66DocuObservaciones);
            Z11TTBUS_Id = A11TTBUS_Id ;
            Z64DocuId = A64DocuId ;
            sMode3 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load013( ) ;
            Gx_mode = sMode3 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound3 = 0 ;
            InitializeNonKey013( ) ;
            sMode3 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal013( ) ;
            Gx_mode = sMode3 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency013( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A11TTBUS_Id, A64DocuId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS000Documentacion"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z65DocuDesc, T00012_A65DocuDesc[0]) != 0 ) || ( StringUtil.StrCmp(Z66DocuObservaciones, T00012_A66DocuObservaciones[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS000Documentacion"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert013( )
      {
         BeforeValidate013( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable013( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM013( 0) ;
            CheckOptimisticConcurrency013( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm013( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert013( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000137 */
                     pr_default.execute(35, new Object[] {A11TTBUS_Id, A64DocuId, A65DocuDesc, A66DocuObservaciones});
                     pr_default.close(35);
                     if ( (pr_default.getStatus(35) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load013( ) ;
            }
            EndLevel013( ) ;
         }
         CloseExtendedTableCursors013( ) ;
      }

      protected void Update013( )
      {
         BeforeValidate013( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable013( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency013( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm013( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate013( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000138 */
                     pr_default.execute(36, new Object[] {A65DocuDesc, A66DocuObservaciones, A11TTBUS_Id, A64DocuId});
                     pr_default.close(36);
                     if ( (pr_default.getStatus(36) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS000Documentacion"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate013( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey013( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel013( ) ;
         }
         CloseExtendedTableCursors013( ) ;
      }

      protected void DeferredUpdate013( )
      {
      }

      protected void Delete013( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate013( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency013( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls013( ) ;
            AfterConfirm013( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete013( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000139 */
                  pr_default.execute(37, new Object[] {A11TTBUS_Id, A64DocuId});
                  pr_default.close(37);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode3 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel013( ) ;
         Gx_mode = sMode3 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls013( )
      {
         standaloneModal013( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel013( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart013( )
      {
         /* Using cursor T000140 */
         pr_default.execute(38, new Object[] {A11TTBUS_Id});
         RcdFound3 = 0 ;
         if ( (pr_default.getStatus(38) != 101) )
         {
            RcdFound3 = 1 ;
            A64DocuId = T000140_A64DocuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DocuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A64DocuId), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext013( )
      {
         pr_default.readNext(38);
         RcdFound3 = 0 ;
         if ( (pr_default.getStatus(38) != 101) )
         {
            RcdFound3 = 1 ;
            A64DocuId = T000140_A64DocuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DocuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A64DocuId), 8, 0)));
         }
      }

      protected void ScanEnd013( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm013( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert013( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate013( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete013( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete013( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate013( )
      {
         /* Before Validate Rules */
      }

      protected void AddRow012( )
      {
         nGXsfl_109_idx = (short)(nGXsfl_109_idx+1) ;
         sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0") ;
         dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_109_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx ;
         SendRow012( ) ;
      }

      protected void SendRow012( )
      {
         Gridttbus000_identificadoresRow = GXWebRow.GetNew(context) ;
         if ( subGridttbus000_identificadores_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridttbus000_identificadores_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridttbus000_identificadores_Class, "") != 0 )
            {
               subGridttbus000_identificadores_Linesclass = subGridttbus000_identificadores_Class+"Odd" ;
            }
         }
         else if ( subGridttbus000_identificadores_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridttbus000_identificadores_Backstyle = 0 ;
            subGridttbus000_identificadores_Backcolor = subGridttbus000_identificadores_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus000_identificadoresContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus000_identificadores_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridttbus000_identificadores_Class, "") != 0 )
            {
               subGridttbus000_identificadores_Linesclass = subGridttbus000_identificadores_Class+"Uniform" ;
            }
         }
         else if ( subGridttbus000_identificadores_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridttbus000_identificadores_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridttbus000_identificadores_Class, "") != 0 )
            {
               subGridttbus000_identificadores_Linesclass = subGridttbus000_identificadores_Class+"Odd" ;
            }
            subGridttbus000_identificadores_Backcolor = (int)(0xF0F0F0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus000_identificadoresContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus000_identificadores_Backcolor), 9, 0)));
         }
         else if ( subGridttbus000_identificadores_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridttbus000_identificadores_Backstyle = 1 ;
            if ( ((int)(nGXsfl_109_idx) % (2)) == 0 )
            {
               subGridttbus000_identificadores_Backcolor = (int)(0xE5E5E5) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus000_identificadoresContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus000_identificadores_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridttbus000_identificadores_Class, "") != 0 )
               {
                  subGridttbus000_identificadores_Linesclass = subGridttbus000_identificadores_Class+"Even" ;
               }
            }
            else
            {
               subGridttbus000_identificadores_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus000_identificadoresContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus000_identificadores_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridttbus000_identificadores_Class, "") != 0 )
               {
                  subGridttbus000_identificadores_Linesclass = subGridttbus000_identificadores_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         GXAIDIDENTIFICADOR_html012( ) ;
         /* Subfile cell */
         ClassString = "Attribute" ;
         StyleString = "" ;
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_109_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_109_idx + "',109)\"" ;
         GXCCtl = "IDIDENTIFICADOR_" + sGXsfl_109_idx ;
         dynIdIdentificador.Name = GXCCtl ;
         dynIdIdentificador.WebTags = "" ;
         /* ComboBox */
         Gridttbus000_identificadoresRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynIdIdentificador,(String)dynIdIdentificador_Internalname,StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0),(String)"",(String)"int",(short)-1,dynIdIdentificador.Enabled,(short)1,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)dynIdIdentificador_Jsonclick,(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(110);\"",(bool)true});
         dynIdIdentificador.CurrentValue = StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynIdIdentificador_Internalname, "Values", (String)(dynIdIdentificador.ToJavascriptSource()));
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_109_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 111,'',false,'" + sGXsfl_109_idx + "',109)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridttbus000_identificadoresRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNumeroIdentificador_Internalname,StringUtil.RTrim( A15NumeroIdentificador),(String)"",(short)300,(String)"px",(short)17,(String)"",(short)80,(short)-1,(int)edtNumeroIdentificador_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(111);\"",(short)0,(String)edtNumeroIdentificador_Jsonclick,(String)"",(short)109,(short)1,(short)-1,(bool)true,(String)"left"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridttbus000_identificadoresRow);
         GXCCtl = "Z14IdIdentificador_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14IdIdentificador), 8, 0, ",", "")));
         GXCCtl = "Z15NumeroIdentificador_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z15NumeroIdentificador));
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_2_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", "")));
         GXCCtl = "nIsMod_2_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", "")));
         GXCCtl = "vTTBUS_ID_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39TTBUS_Id), 8, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTTBUS_CODPOSICION_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34TTBUS_CodPosicion), 3, 0, ",", "")));
         GXCCtl = "vPSEC_CRE_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV28pSEC_CRE));
         GXCCtl = "vTTBUS_ESTADO_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38TTBUS_Estado), 1, 0, ",", "")));
         GXCCtl = "vCONSULTA_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16consulta), 4, 0, ",", "")));
         GXCCtl = "vSISTEMA_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV32SISTEMA));
         GXCCtl = "vUSUARIO_" + sGXsfl_109_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV51USUARIO));
         GxWebStd.gx_hidden_field( context, "IDIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dynIdIdentificador.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtNumeroIdentificador_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridttbus000_identificadoresContainer.AddRow(Gridttbus000_identificadoresRow);
      }

      protected void ReadRow012( )
      {
         nGXsfl_109_idx = (short)(nGXsfl_109_idx+1) ;
         sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0") ;
         dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_109_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx ;
         dynIdIdentificador.Enabled = (int)(context.localUtil.CToN( cgiGet( "IDIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynIdIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynIdIdentificador.Enabled), 5, 0)));
         edtNumeroIdentificador_Enabled = (int)(context.localUtil.CToN( cgiGet( "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNumeroIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNumeroIdentificador_Enabled), 5, 0)));
         dynIdIdentificador.Name = dynIdIdentificador_Internalname ;
         dynIdIdentificador.CurrentValue = cgiGet( dynIdIdentificador_Internalname) ;
         A14IdIdentificador = (int)(NumberUtil.Val( cgiGet( dynIdIdentificador_Internalname), ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
         A15NumeroIdentificador = cgiGet( edtNumeroIdentificador_Internalname) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
         GXCCtl = "Z14IdIdentificador_" + sGXsfl_109_idx ;
         Z14IdIdentificador = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "Z15NumeroIdentificador_" + sGXsfl_109_idx ;
         Z15NumeroIdentificador = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_109_idx ;
         nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nRcdExists_2_" + sGXsfl_109_idx ;
         nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nIsMod_2_" + sGXsfl_109_idx ;
         nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vTTBUS_ID_" + sGXsfl_109_idx ;
         AV39TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vTTBUS_CODPOSICION_" + sGXsfl_109_idx ;
         AV34TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vPSEC_CRE_" + sGXsfl_109_idx ;
         AV28pSEC_CRE = cgiGet( GXCCtl) ;
         GXCCtl = "vTTBUS_ESTADO_" + sGXsfl_109_idx ;
         AV38TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vCONSULTA_" + sGXsfl_109_idx ;
         AV16consulta = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vSISTEMA_" + sGXsfl_109_idx ;
         AV32SISTEMA = cgiGet( GXCCtl) ;
         GXCCtl = "vUSUARIO_" + sGXsfl_109_idx ;
         AV51USUARIO = cgiGet( GXCCtl) ;
      }

      protected void AddRow013( )
      {
         nGXsfl_118_idx = (short)(nGXsfl_118_idx+1) ;
         sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_118_idx), 4, 0)), 4, "0") ;
         edtDocuId_Internalname = "DOCUID_"+sGXsfl_118_idx ;
         edtDocuDesc_Internalname = "DOCUDESC_"+sGXsfl_118_idx ;
         edtDocuObservaciones_Internalname = "DOCUOBSERVACIONES_"+sGXsfl_118_idx ;
         SendRow013( ) ;
      }

      protected void SendRow013( )
      {
         Gridttbus000_documentacionRow = GXWebRow.GetNew(context) ;
         if ( subGridttbus000_documentacion_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridttbus000_documentacion_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridttbus000_documentacion_Class, "") != 0 )
            {
               subGridttbus000_documentacion_Linesclass = subGridttbus000_documentacion_Class+"Odd" ;
            }
         }
         else if ( subGridttbus000_documentacion_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridttbus000_documentacion_Backstyle = 0 ;
            subGridttbus000_documentacion_Backcolor = subGridttbus000_documentacion_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus000_documentacionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus000_documentacion_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridttbus000_documentacion_Class, "") != 0 )
            {
               subGridttbus000_documentacion_Linesclass = subGridttbus000_documentacion_Class+"Uniform" ;
            }
         }
         else if ( subGridttbus000_documentacion_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridttbus000_documentacion_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridttbus000_documentacion_Class, "") != 0 )
            {
               subGridttbus000_documentacion_Linesclass = subGridttbus000_documentacion_Class+"Odd" ;
            }
            subGridttbus000_documentacion_Backcolor = (int)(0xF0F0F0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus000_documentacionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus000_documentacion_Backcolor), 9, 0)));
         }
         else if ( subGridttbus000_documentacion_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridttbus000_documentacion_Backstyle = 1 ;
            if ( ((int)(nGXsfl_118_idx) % (2)) == 0 )
            {
               subGridttbus000_documentacion_Backcolor = (int)(0xE5E5E5) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus000_documentacionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus000_documentacion_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridttbus000_documentacion_Class, "") != 0 )
               {
                  subGridttbus000_documentacion_Linesclass = subGridttbus000_documentacion_Class+"Even" ;
               }
            }
            else
            {
               subGridttbus000_documentacion_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus000_documentacionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus000_documentacion_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridttbus000_documentacion_Class, "") != 0 )
               {
                  subGridttbus000_documentacion_Linesclass = subGridttbus000_documentacion_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridttbus000_documentacionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDocuId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A64DocuId), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(int)edtDocuId_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A64DocuId), "ZZZZZZZ9"),(String)"",(short)0,(String)edtDocuId_Jsonclick,(String)"",(short)118,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Multiple line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_118_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 120,'',false,'" + sGXsfl_118_idx + "',118)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         Gridttbus000_documentacionRow.AddColumnProperties("html_textarea", 1, isAjaxCallMode( ), new Object[] {(String)edtDocuDesc_Internalname,StringUtil.RTrim( A65DocuDesc),(short)-1,(int)edtDocuDesc_Enabled,(short)0,(short)200,(String)"px",(short)51,(String)"",(String)StyleString,(String)ClassString,(String)"80",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(120);\"",(short)1,(short)0,(String)"",(String)"",(bool)true});
         /* Subfile cell */
         /* Multiple line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_118_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 121,'',false,'" + sGXsfl_118_idx + "',118)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         Gridttbus000_documentacionRow.AddColumnProperties("html_textarea", 1, isAjaxCallMode( ), new Object[] {(String)edtDocuObservaciones_Internalname,StringUtil.RTrim( A66DocuObservaciones),(short)-1,(int)edtDocuObservaciones_Enabled,(short)0,(short)450,(String)"px",(short)51,(String)"",(String)StyleString,(String)ClassString,(String)"200",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(121);\"",(short)1,(short)0,(String)"",(String)"",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridttbus000_documentacionRow);
         GXCCtl = "Z64DocuId_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z64DocuId), 8, 0, ",", "")));
         GXCCtl = "Z65DocuDesc_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z65DocuDesc));
         GXCCtl = "Z66DocuObservaciones_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z66DocuObservaciones));
         GXCCtl = "nRcdDeleted_3_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_3_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ",", "")));
         GXCCtl = "nIsMod_3_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ",", "")));
         GXCCtl = "vTTBUS_ID_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39TTBUS_Id), 8, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTTBUS_CODPOSICION_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34TTBUS_CodPosicion), 3, 0, ",", "")));
         GXCCtl = "vPSEC_CRE_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV28pSEC_CRE));
         GXCCtl = "vTTBUS_ESTADO_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38TTBUS_Estado), 1, 0, ",", "")));
         GXCCtl = "vCONSULTA_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16consulta), 4, 0, ",", "")));
         GXCCtl = "vSISTEMA_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV32SISTEMA));
         GXCCtl = "vUSUARIO_" + sGXsfl_118_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV51USUARIO));
         GxWebStd.gx_hidden_field( context, "DOCUID_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DOCUDESC_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuDesc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DOCUOBSERVACIONES_"+sGXsfl_118_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocuObservaciones_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridttbus000_documentacionContainer.AddRow(Gridttbus000_documentacionRow);
      }

      protected void ReadRow013( )
      {
         nGXsfl_118_idx = (short)(nGXsfl_118_idx+1) ;
         sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_118_idx), 4, 0)), 4, "0") ;
         edtDocuId_Internalname = "DOCUID_"+sGXsfl_118_idx ;
         edtDocuDesc_Internalname = "DOCUDESC_"+sGXsfl_118_idx ;
         edtDocuObservaciones_Internalname = "DOCUOBSERVACIONES_"+sGXsfl_118_idx ;
         edtDocuId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCUID_"+sGXsfl_118_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuId_Enabled), 5, 0)));
         edtDocuDesc_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCUDESC_"+sGXsfl_118_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuDesc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuDesc_Enabled), 5, 0)));
         edtDocuObservaciones_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCUOBSERVACIONES_"+sGXsfl_118_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuObservaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuObservaciones_Enabled), 5, 0)));
         A64DocuId = (int)(context.localUtil.CToN( cgiGet( edtDocuId_Internalname), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DocuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A64DocuId), 8, 0)));
         A65DocuDesc = cgiGet( edtDocuDesc_Internalname) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DocuDesc", A65DocuDesc);
         A66DocuObservaciones = StringUtil.Upper( cgiGet( edtDocuObservaciones_Internalname)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66DocuObservaciones", A66DocuObservaciones);
         GXCCtl = "Z64DocuId_" + sGXsfl_118_idx ;
         Z64DocuId = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "Z65DocuDesc_" + sGXsfl_118_idx ;
         Z65DocuDesc = cgiGet( GXCCtl) ;
         GXCCtl = "Z66DocuObservaciones_" + sGXsfl_118_idx ;
         Z66DocuObservaciones = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_3_" + sGXsfl_118_idx ;
         nRcdDeleted_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nRcdExists_3_" + sGXsfl_118_idx ;
         nRcdExists_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nIsMod_3_" + sGXsfl_118_idx ;
         nIsMod_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vTTBUS_ID_" + sGXsfl_118_idx ;
         AV39TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vTTBUS_CODPOSICION_" + sGXsfl_118_idx ;
         AV34TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vPSEC_CRE_" + sGXsfl_118_idx ;
         AV28pSEC_CRE = cgiGet( GXCCtl) ;
         GXCCtl = "vTTBUS_ESTADO_" + sGXsfl_118_idx ;
         AV38TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vCONSULTA_" + sGXsfl_118_idx ;
         AV16consulta = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vSISTEMA_" + sGXsfl_118_idx ;
         AV32SISTEMA = cgiGet( GXCCtl) ;
         GXCCtl = "vUSUARIO_" + sGXsfl_118_idx ;
         AV51USUARIO = cgiGet( GXCCtl) ;
      }

      protected void assign_properties_default( )
      {
         defedtDocuId_Enabled = edtDocuId_Enabled ;
         defdynIdIdentificador_Enabled = dynIdIdentificador.Enabled ;
      }

      protected void ConfirmValues010( )
      {
         nGXsfl_109_idx = 0 ;
         sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0") ;
         dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_109_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx ;
         while ( nGXsfl_109_idx < nRC_Gridttbus000_identificadores )
         {
            nGXsfl_109_idx = (short)(nGXsfl_109_idx+1) ;
            sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0") ;
            dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_109_idx ;
            edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx ;
            ChangePostValue( "Z14IdIdentificador_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z14IdIdentificador_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z14IdIdentificador_"+sGXsfl_109_idx) ;
            ChangePostValue( "Z15NumeroIdentificador_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z15NumeroIdentificador_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z15NumeroIdentificador_"+sGXsfl_109_idx) ;
         }
         nGXsfl_118_idx = 0 ;
         sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_118_idx), 4, 0)), 4, "0") ;
         edtDocuId_Internalname = "DOCUID_"+sGXsfl_118_idx ;
         edtDocuDesc_Internalname = "DOCUDESC_"+sGXsfl_118_idx ;
         edtDocuObservaciones_Internalname = "DOCUOBSERVACIONES_"+sGXsfl_118_idx ;
         while ( nGXsfl_118_idx < nRC_Gridttbus000_documentacion )
         {
            nGXsfl_118_idx = (short)(nGXsfl_118_idx+1) ;
            sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_118_idx), 4, 0)), 4, "0") ;
            edtDocuId_Internalname = "DOCUID_"+sGXsfl_118_idx ;
            edtDocuDesc_Internalname = "DOCUDESC_"+sGXsfl_118_idx ;
            edtDocuObservaciones_Internalname = "DOCUOBSERVACIONES_"+sGXsfl_118_idx ;
            ChangePostValue( "Z64DocuId_"+sGXsfl_118_idx, cgiGet( "ZT_"+"Z64DocuId_"+sGXsfl_118_idx)) ;
            DeletePostValue( "ZT_"+"Z64DocuId_"+sGXsfl_118_idx) ;
            ChangePostValue( "Z65DocuDesc_"+sGXsfl_118_idx, cgiGet( "ZT_"+"Z65DocuDesc_"+sGXsfl_118_idx)) ;
            DeletePostValue( "ZT_"+"Z65DocuDesc_"+sGXsfl_118_idx) ;
            ChangePostValue( "Z66DocuObservaciones_"+sGXsfl_118_idx, cgiGet( "ZT_"+"Z66DocuObservaciones_"+sGXsfl_118_idx)) ;
            DeletePostValue( "ZT_"+"Z66DocuObservaciones_"+sGXsfl_118_idx) ;
         }
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus000.aspx") + "?" + UrlEncode("" +AV39TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV34TTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV28pSEC_CRE)) + "," + UrlEncode("" +AV38TTBUS_Estado) + "," + UrlEncode("" +AV16consulta) + "," + UrlEncode(StringUtil.RTrim(AV32SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV51USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z11TTBUS_Id", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z13TTBUS_FechaCarga", context.localUtil.DToC( Z13TTBUS_FechaCarga, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z38TTBUS_DesPosicion", StringUtil.RTrim( Z38TTBUS_DesPosicion));
         GxWebStd.gx_hidden_field( context, "Z75TTBUS_UsuarioAlta", StringUtil.RTrim( Z75TTBUS_UsuarioAlta));
         GxWebStd.gx_hidden_field( context, "Z76TTBUS_MaquinaAlta", StringUtil.RTrim( Z76TTBUS_MaquinaAlta));
         GxWebStd.gx_hidden_field( context, "Z12TTBUS_Descripcion", StringUtil.RTrim( Z12TTBUS_Descripcion));
         GxWebStd.gx_hidden_field( context, "Z23TTBUS_Estado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23TTBUS_Estado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z29TTBUS_Alquilado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29TTBUS_Alquilado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z74TTBUS_ContDocu), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z42TTBUS_NroSerie", StringUtil.RTrim( Z42TTBUS_NroSerie));
         GxWebStd.gx_hidden_field( context, "Z27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27TTBUS_CodProveedor), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37TTBUS_CodPosicion), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17TTBUS_RubroBien), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.NToC( (decimal)(O74TTBUS_ContDocu), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridttbus000_identificadores", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_109_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_Gridttbus000_documentacion", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_118_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTTBUS_CODPOSICION", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34TTBUS_CodPosicion), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPSEC_CRE", StringUtil.RTrim( AV28pSEC_CRE));
         GxWebStd.gx_hidden_field( context, "vTTBUS_ESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38TTBUS_Estado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vCONSULTA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16consulta), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV32SISTEMA));
         GxWebStd.gx_hidden_field( context, "vTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vDUP_CONT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18dup_cont), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vDUP_HW", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19dup_hw), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV51USUARIO));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_ESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TTBUS_Estado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSEC_CRE", StringUtil.RTrim( AV29SEC_CRE));
         GxWebStd.gx_hidden_field( context, "vCOD_ERROR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cod_error), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMJE_ERROR", StringUtil.RTrim( AV25mje_error));
         GxWebStd.gx_hidden_field( context, "TTBUS_CONTDOCU", StringUtil.LTrim( StringUtil.NToC( (decimal)(A74TTBUS_ContDocu), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vCOD_ERROR1", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cod_error1), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMJE_ERROR1", StringUtil.RTrim( AV26mje_error1));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "TTBUS000" ;
      }

      public override String GetPgmdesc( )
      {
         return "Bienes de Uso (Trazabilidad)" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus000.aspx") + "?" + UrlEncode("" +AV39TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV34TTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV28pSEC_CRE)) + "," + UrlEncode("" +AV38TTBUS_Estado) + "," + UrlEncode("" +AV16consulta) + "," + UrlEncode(StringUtil.RTrim(AV32SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV51USUARIO)) ;
      }

      protected void InitializeNonKey011( )
      {
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
         A38TTBUS_DesPosicion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
         AV29SEC_CRE = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SEC_CRE", AV29SEC_CRE);
         AV30SEC_DRE = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30SEC_DRE", AV30SEC_DRE);
         AV14cod_error = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cod_error", StringUtil.Str( (decimal)(AV14cod_error), 1, 0));
         AV25mje_error = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25mje_error", AV25mje_error);
         A75TTBUS_UsuarioAlta = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75TTBUS_UsuarioAlta", A75TTBUS_UsuarioAlta);
         A76TTBUS_MaquinaAlta = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76TTBUS_MaquinaAlta", A76TTBUS_MaquinaAlta);
         A12TTBUS_Descripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         A27TTBUS_CodProveedor = 0 ;
         n27TTBUS_CodProveedor = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
         n27TTBUS_CodProveedor = ((0==A27TTBUS_CodProveedor) ? true : false) ;
         A30TTBUS_DesProveedor = "" ;
         n30TTBUS_DesProveedor = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
         A29TTBUS_Alquilado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
         A37TTBUS_CodPosicion = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
         A17TTBUS_RubroBien = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
         A18TTBUS_RubroDesc = "" ;
         n18TTBUS_RubroDesc = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
         A74TTBUS_ContDocu = 0 ;
         n74TTBUS_ContDocu = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
         A42TTBUS_NroSerie = "" ;
         n42TTBUS_NroSerie = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42TTBUS_NroSerie", A42TTBUS_NroSerie);
         n42TTBUS_NroSerie = (String.IsNullOrEmpty(StringUtil.RTrim( A42TTBUS_NroSerie)) ? true : false) ;
         A23TTBUS_Estado = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
         O74TTBUS_ContDocu = A74TTBUS_ContDocu ;
         n74TTBUS_ContDocu = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
      }

      protected void InitAll011( )
      {
         A11TTBUS_Id = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A23TTBUS_Estado = i23TTBUS_Estado ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
      }

      protected void InitializeNonKey012( )
      {
         AV15cod_error1 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cod_error1", StringUtil.Str( (decimal)(AV15cod_error1), 1, 0));
         AV26mje_error1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26mje_error1", AV26mje_error1);
         A15NumeroIdentificador = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
      }

      protected void InitAll012( )
      {
         A14IdIdentificador = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
         InitializeNonKey012( ) ;
      }

      protected void StandaloneModalInsert012( )
      {
      }

      protected void InitializeNonKey013( )
      {
         A65DocuDesc = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DocuDesc", A65DocuDesc);
         A66DocuObservaciones = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66DocuObservaciones", A66DocuObservaciones);
      }

      protected void InitAll013( )
      {
         A64DocuId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DocuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A64DocuId), 8, 0)));
         InitializeNonKey013( ) ;
      }

      protected void StandaloneModalInsert013( )
      {
         A74TTBUS_ContDocu = i74TTBUS_ContDocu ;
         n74TTBUS_ContDocu = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13221325");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus000.js", "?13221326");
         /* End function include_jscripts */
      }

      protected void init_level_properties2( )
      {
         dynIdIdentificador.Enabled = defdynIdIdentificador_Enabled ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynIdIdentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynIdIdentificador.Enabled), 5, 0)));
      }

      protected void init_level_properties3( )
      {
         edtDocuId_Enabled = defedtDocuId_Enabled ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocuId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocuId_Enabled), 5, 0)));
      }

      protected void init_default_properties( )
      {
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockttbus_descripcion2_Internalname = "TEXTBLOCKTTBUS_DESCRIPCION2" ;
         edtTTBUS_Id_Internalname = "TTBUS_ID" ;
         lblTextblockttbus_descripcion_Internalname = "TEXTBLOCKTTBUS_DESCRIPCION" ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtTTBUS_NroSerie_Internalname = "TTBUS_NROSERIE" ;
         lblTextblockttbus_fechacarga_Internalname = "TEXTBLOCKTTBUS_FECHACARGA" ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA" ;
         lblTextblockttbus_fechacarga2_Internalname = "TEXTBLOCKTTBUS_FECHACARGA2" ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR" ;
         edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR" ;
         lblTextblockttbus_fechacarga5_Internalname = "TEXTBLOCKTTBUS_FECHACARGA5" ;
         edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN" ;
         edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC" ;
         lblTextblockttbus_fechacarga4_Internalname = "TEXTBLOCKTTBUS_FECHACARGA4" ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO" ;
         lblTitleidentificadores2_Internalname = "TITLEIDENTIFICADORES2" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION" ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         edtavSec_dre_Internalname = "vSEC_DRE" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO" ;
         lblTextblock16_Internalname = "TEXTBLOCK16" ;
         edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtTTBUS_UsuarioAlta_Internalname = "TTBUS_USUARIOALTA" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtTTBUS_MaquinaAlta_Internalname = "TTBUS_MAQUINAALTA" ;
         lblTitleidentificadores_Internalname = "TITLEIDENTIFICADORES" ;
         tblTable3_Internalname = "TABLE3" ;
         lblTitledocumentacion_Internalname = "TITLEDOCUMENTACION" ;
         tblTable5_Internalname = "TABLE5" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable7_Internalname = "TABLE7" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_27_Internalname = "PROMPT_27" ;
         imgprompt_17_Internalname = "PROMPT_17" ;
         imgprompt_37_Internalname = "PROMPT_37" ;
         subGridttbus000_identificadores_Internalname = "GRIDTTBUS000_IDENTIFICADORES" ;
         subGridttbus000_documentacion_Internalname = "GRIDTTBUS000_DOCUMENTACION" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Bienes de Uso (Trazabilidad)" ;
         edtDocuId_Jsonclick = "" ;
         subGridttbus000_documentacion_Class = "Grid" ;
         edtNumeroIdentificador_Jsonclick = "" ;
         dynIdIdentificador_Jsonclick = "" ;
         subGridttbus000_identificadores_Class = "Grid" ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         edtDocuObservaciones_Enabled = 1 ;
         edtDocuDesc_Enabled = 1 ;
         edtDocuId_Enabled = 0 ;
         subGridttbus000_documentacion_Backcolorstyle = 3 ;
         edtNumeroIdentificador_Enabled = 1 ;
         dynIdIdentificador.Enabled = 1 ;
         subGridttbus000_identificadores_Backcolorstyle = 3 ;
         edtTTBUS_MaquinaAlta_Jsonclick = "" ;
         edtTTBUS_MaquinaAlta_Enabled = 0 ;
         edtTTBUS_UsuarioAlta_Jsonclick = "" ;
         edtTTBUS_UsuarioAlta_Enabled = 0 ;
         edtavTtbus2_observaciones_Enabled = 0 ;
         edtavTtbus2_plazorecepcion_Jsonclick = "" ;
         edtavTtbus2_plazorecepcion_Enabled = 0 ;
         edtavTtbus2_motivoenvio_Jsonclick = "" ;
         edtavTtbus2_motivoenvio_Enabled = 0 ;
         edtavSec_dre_Jsonclick = "" ;
         edtavSec_dre_Enabled = 0 ;
         edtTTBUS_DesPosicion_Jsonclick = "" ;
         edtTTBUS_DesPosicion_Enabled = 0 ;
         imgprompt_37_Visible = 1 ;
         imgprompt_37_Link = "" ;
         edtTTBUS_CodPosicion_Jsonclick = "" ;
         edtTTBUS_CodPosicion_Enabled = 1 ;
         chkTTBUS_Alquilado.Enabled = 1 ;
         edtTTBUS_RubroDesc_Jsonclick = "" ;
         edtTTBUS_RubroDesc_Enabled = 0 ;
         imgprompt_17_Visible = 1 ;
         imgprompt_17_Link = "" ;
         edtTTBUS_RubroBien_Jsonclick = "" ;
         edtTTBUS_RubroBien_Enabled = 1 ;
         edtTTBUS_DesProveedor_Jsonclick = "" ;
         edtTTBUS_DesProveedor_Enabled = 0 ;
         imgprompt_27_Visible = 1 ;
         imgprompt_27_Link = "" ;
         edtTTBUS_CodProveedor_Jsonclick = "" ;
         edtTTBUS_CodProveedor_Enabled = 1 ;
         edtTTBUS_FechaCarga_Jsonclick = "" ;
         edtTTBUS_FechaCarga_Enabled = 0 ;
         edtTTBUS_NroSerie_Jsonclick = "" ;
         edtTTBUS_NroSerie_Enabled = 1 ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Descripcion_Enabled = 1 ;
         edtTTBUS_Id_Jsonclick = "" ;
         edtTTBUS_Id_Enabled = 0 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         chkTTBUS_Alquilado.Caption = "" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGATTBUS_DESCRIPCION010( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data010( A12TTBUS_Descripcion) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXSGATTBUS_DESCRIPCION_data010( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor T000141 */
         pr_default.execute(39, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(39) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000141_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000141_A12TTBUS_Descripcion[0]));
            pr_default.readNext(39);
         }
         pr_default.close(39);
      }

      protected void GXDLAIDIDENTIFICADOR012( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLAIDIDENTIFICADOR_data012( ) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXAIDIDENTIFICADOR_html012( )
      {
         int gxdynajaxvalue ;
         GXDLAIDIDENTIFICADOR_data012( ) ;
         gxdynajaxindex = 1 ;
         dynIdIdentificador.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynIdIdentificador.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 8, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLAIDIDENTIFICADOR_data012( )
      {
         /* Using cursor T000142 */
         pr_default.execute(40);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("");
         while ( (pr_default.getStatus(40) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000142_A14IdIdentificador[0]), 8, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000142_A21TTBUS5_DescIdentificador[0]));
            pr_default.readNext(40);
         }
         pr_default.close(40);
      }

      protected void XC_13_011( int A11TTBUS_Id ,
                                short A37TTBUS_CodPosicion )
      {
         new pttbus000_5(context ).execute(  A11TTBUS_Id,  A37TTBUS_CodPosicion, out  A38TTBUS_DesPosicion, out  AV29SEC_CRE, out  AV30SEC_DRE) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SEC_CRE", AV29SEC_CRE);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30SEC_DRE", AV30SEC_DRE);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A38TTBUS_DesPosicion))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV29SEC_CRE))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV30SEC_DRE))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_16_011( short A37TTBUS_CodPosicion ,
                                String Gx_mode ,
                                String AV51USUARIO )
      {
         if ( true /* After */ && ( A37TTBUS_CodPosicion != 999 ) )
         {
            new pttbus000_8(context ).execute(  A37TTBUS_CodPosicion,  Gx_mode,  AV51USUARIO, out  AV14cod_error, out  AV25mje_error) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51USUARIO", AV51USUARIO);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cod_error", StringUtil.Str( (decimal)(AV14cod_error), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25mje_error", AV25mje_error);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cod_error), 1, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV25mje_error))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_21_012( int A11TTBUS_Id ,
                                int A14IdIdentificador ,
                                String A15NumeroIdentificador ,
                                String Gx_mode )
      {
         if ( true /* After */ && ( ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) || ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) ) ) )
         {
            new pttbus000_10(context ).execute(  A11TTBUS_Id,  A14IdIdentificador,  A15NumeroIdentificador, out  AV15cod_error1, out  AV26mje_error1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cod_error1", StringUtil.Str( (decimal)(AV15cod_error1), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26mje_error1", AV26mje_error1);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cod_error1), 1, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV26mje_error1))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void gxnrGridttbus000_identificadores_newrow( short nRC_Gridttbus000_identificadores ,
                                                              short nGXsfl_109_idx ,
                                                              String sGXsfl_109_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_109_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx ;
         while ( nGXsfl_109_idx <= nRC_Gridttbus000_identificadores )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            chkTTBUS_Alquilado.Name = "TTBUS_ALQUILADO" ;
            chkTTBUS_Alquilado.WebTags = "" ;
            chkTTBUS_Alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
            chkTTBUS_Alquilado.CheckedValue = "0" ;
            GXCCtl = "IDIDENTIFICADOR_" + sGXsfl_109_idx ;
            dynIdIdentificador.Name = GXCCtl ;
            dynIdIdentificador.WebTags = "" ;
            dynload_actions( ) ;
            SendRow012( ) ;
            nGXsfl_109_idx = (short)(nGXsfl_109_idx+1) ;
            sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0") ;
            dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_109_idx ;
            edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_109_idx ;
         }
         context.GX_webresponse.AddString(Gridttbus000_identificadoresContainer.ToJavascriptSource());
         /* End function gxnrGridttbus000_identificadores_newrow */
      }

      protected void gxnrGridttbus000_documentacion_newrow( short nRC_Gridttbus000_documentacion ,
                                                            short nGXsfl_118_idx ,
                                                            String sGXsfl_118_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtDocuId_Internalname = "DOCUID_"+sGXsfl_118_idx ;
         edtDocuDesc_Internalname = "DOCUDESC_"+sGXsfl_118_idx ;
         edtDocuObservaciones_Internalname = "DOCUOBSERVACIONES_"+sGXsfl_118_idx ;
         while ( nGXsfl_118_idx <= nRC_Gridttbus000_documentacion )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal013( ) ;
            standaloneModal013( ) ;
            chkTTBUS_Alquilado.Name = "TTBUS_ALQUILADO" ;
            chkTTBUS_Alquilado.WebTags = "" ;
            chkTTBUS_Alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
            chkTTBUS_Alquilado.CheckedValue = "0" ;
            GXCCtl = "IDIDENTIFICADOR_" + sGXsfl_109_idx ;
            dynIdIdentificador.Name = GXCCtl ;
            dynIdIdentificador.WebTags = "" ;
            dynload_actions( ) ;
            SendRow013( ) ;
            nGXsfl_118_idx = (short)(nGXsfl_118_idx+1) ;
            sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_118_idx), 4, 0)), 4, "0") ;
            edtDocuId_Internalname = "DOCUID_"+sGXsfl_118_idx ;
            edtDocuDesc_Internalname = "DOCUDESC_"+sGXsfl_118_idx ;
            edtDocuObservaciones_Internalname = "DOCUOBSERVACIONES_"+sGXsfl_118_idx ;
         }
         context.GX_webresponse.AddString(Gridttbus000_documentacionContainer.ToJavascriptSource());
         /* End function gxnrGridttbus000_documentacion_newrow */
      }

      public void Valid_Ttbus_codproveedor( int GX_Parm1 ,
                                            String GX_Parm2 )
      {
         A27TTBUS_CodProveedor = GX_Parm1 ;
         n27TTBUS_CodProveedor = false ;
         A30TTBUS_DesProveedor = GX_Parm2 ;
         n30TTBUS_DesProveedor = false ;
         /* Using cursor T000124 */
         pr_default.execute(22, new Object[] {n27TTBUS_CodProveedor, A27TTBUS_CodProveedor});
         if ( (pr_default.getStatus(22) == 101) )
         {
            if ( ! ( (0==A27TTBUS_CodProveedor) ) )
            {
               GX_msglist.addItem("No existe 'Proveedor de bien de uso'.", "ForeignKeyNotFound", 1, "TTBUS_CODPROVEEDOR");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS_CodProveedor_Internalname ;
            }
         }
         if ( AnyError == 0 )
         {
            A30TTBUS_DesProveedor = T000124_A30TTBUS_DesProveedor[0] ;
            n30TTBUS_DesProveedor = T000124_n30TTBUS_DesProveedor[0] ;
         }
         pr_default.close(22);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A30TTBUS_DesProveedor = "" ;
            n30TTBUS_DesProveedor = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A30TTBUS_DesProveedor)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Ttbus_rubrobien( short GX_Parm1 ,
                                         String GX_Parm2 )
      {
         A17TTBUS_RubroBien = GX_Parm1 ;
         A18TTBUS_RubroDesc = GX_Parm2 ;
         n18TTBUS_RubroDesc = false ;
         /* Using cursor T000125 */
         pr_default.execute(23, new Object[] {A17TTBUS_RubroBien});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No existe 'Rubro de bien de uso'.", "ForeignKeyNotFound", 1, "TTBUS_RUBROBIEN");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS_RubroBien_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A18TTBUS_RubroDesc = T000125_A18TTBUS_RubroDesc[0] ;
            n18TTBUS_RubroDesc = T000125_n18TTBUS_RubroDesc[0] ;
         }
         pr_default.close(23);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A18TTBUS_RubroDesc = "" ;
            n18TTBUS_RubroDesc = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A18TTBUS_RubroDesc)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Ttbus_codposicion( String GX_Parm1 ,
                                           String GX_Parm2 ,
                                           short GX_Parm3 ,
                                           int GX_Parm4 ,
                                           String GX_Parm5 ,
                                           String GX_Parm6 ,
                                           String GX_Parm7 ,
                                           short GX_Parm8 ,
                                           String GX_Parm9 )
      {
         AV51USUARIO = GX_Parm1 ;
         Gx_mode = GX_Parm2 ;
         A37TTBUS_CodPosicion = GX_Parm3 ;
         A11TTBUS_Id = GX_Parm4 ;
         A38TTBUS_DesPosicion = GX_Parm5 ;
         AV29SEC_CRE = GX_Parm6 ;
         AV30SEC_DRE = GX_Parm7 ;
         AV14cod_error = GX_Parm8 ;
         AV25mje_error = GX_Parm9 ;
         /* Using cursor T000143 */
         pr_default.execute(41, new Object[] {A37TTBUS_CodPosicion});
         if ( (pr_default.getStatus(41) == 101) )
         {
            GX_msglist.addItem("No existe 'Posición de Bien de Uso'.", "ForeignKeyNotFound", 1, "TTBUS_CODPOSICION");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS_CodPosicion_Internalname ;
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(41);
         new pttbus000_5(context ).execute(  A11TTBUS_Id,  A37TTBUS_CodPosicion, out  A38TTBUS_DesPosicion, out  AV29SEC_CRE, out  AV30SEC_DRE) ;
         if ( ( ( A37TTBUS_CodPosicion == 0 ) ) && true /* After */ )
         {
            GX_msglist.addItem("DEBE SELECCIONAR UNA POSICIÓN ACTUAL PARA EL BIEN.", 1, "TTBUS_CODPOSICION");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS_CodPosicion_Internalname ;
         }
         if ( true /* After */ && ( A37TTBUS_CodPosicion != 999 ) )
         {
            new pttbus000_8(context ).execute(  A37TTBUS_CodPosicion,  Gx_mode,  AV51USUARIO, out  AV14cod_error, out  AV25mje_error) ;
         }
         if ( true /* After */ && ( AV14cod_error == 1 ) && ( A37TTBUS_CodPosicion != 999 ) )
         {
            GX_msglist.addItem(StringUtil.Trim( AV25mje_error), 1, "TTBUS_CODPOSICION");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS_CodPosicion_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A38TTBUS_DesPosicion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV29SEC_CRE)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV30SEC_DRE)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cod_error), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV25mje_error)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Ididentificador( GXCombobox dynGX_Parm1 )
      {
         dynIdIdentificador = dynGX_Parm1 ;
         A14IdIdentificador = (int)(NumberUtil.Val( dynIdIdentificador.CurrentValue, ".")) ;
         /* Using cursor T000144 */
         pr_default.execute(42, new Object[] {A14IdIdentificador});
         if ( (pr_default.getStatus(42) == 101) )
         {
            GX_msglist.addItem("No existe 'Identificador de Bien de Uso'.", "ForeignKeyNotFound", 1, "IDIDENTIFICADOR");
            AnyError = 1 ;
            GX_FocusControl = dynIdIdentificador_Internalname ;
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(42);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Numeroidentificador( String GX_Parm1 ,
                                             GXCombobox dynGX_Parm2 ,
                                             int GX_Parm3 ,
                                             String GX_Parm4 ,
                                             String GX_Parm5 ,
                                             short GX_Parm6 )
      {
         Gx_mode = GX_Parm1 ;
         dynIdIdentificador = dynGX_Parm2 ;
         A14IdIdentificador = (int)(NumberUtil.Val( dynIdIdentificador.CurrentValue, ".")) ;
         A11TTBUS_Id = GX_Parm3 ;
         A15NumeroIdentificador = GX_Parm4 ;
         AV26mje_error1 = GX_Parm5 ;
         AV15cod_error1 = GX_Parm6 ;
         if ( ( ( A14IdIdentificador != 0 ) ) && ( StringUtil.StrCmp(StringUtil.Trim( A15NumeroIdentificador), "") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("DEBE INGRESAR UN CÓDIGO PARA EL IDENTIFICADOR SELECCIONADO.", 1, "NUMEROIDENTIFICADOR");
            AnyError = 1 ;
            GX_FocusControl = edtNumeroIdentificador_Internalname ;
         }
         if ( ( ( A14IdIdentificador == 0 ) ) && ! ( StringUtil.StrCmp(StringUtil.Trim( A15NumeroIdentificador), "") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("DEBE SELECCIONAR UN IDENTIFICADOR PARA EL CÓDIGO CARGADO.", 1, "NUMEROIDENTIFICADOR");
            AnyError = 1 ;
            GX_FocusControl = edtNumeroIdentificador_Internalname ;
         }
         if ( true /* After */ && ( ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) || ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) ) ) )
         {
            new pttbus000_10(context ).execute(  A11TTBUS_Id,  A14IdIdentificador,  A15NumeroIdentificador, out  AV15cod_error1, out  AV26mje_error1) ;
         }
         if ( AV15cod_error1 == 1 )
         {
            GX_msglist.addItem(AV26mje_error1, 1, "NUMEROIDENTIFICADOR");
            AnyError = 1 ;
            GX_FocusControl = edtNumeroIdentificador_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cod_error1), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV26mje_error1)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(38);
         pr_default.close(32);
         pr_default.close(42);
         pr_default.close(25);
         pr_default.close(16);
         pr_default.close(15);
         pr_default.close(22);
         pr_default.close(41);
         pr_default.close(23);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV28pSEC_CRE = "" ;
         wcpOAV32SISTEMA = "" ;
         wcpOAV51USUARIO = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A15NumeroIdentificador = "" ;
         A12TTBUS_Descripcion = "" ;
         GXCCtl = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_delete_Jsonclick = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockttbus_descripcion2_Jsonclick = "" ;
         lblTextblockttbus_descripcion_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         A42TTBUS_NroSerie = "" ;
         lblTextblockttbus_fechacarga_Jsonclick = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         lblTextblockttbus_fechacarga2_Jsonclick = "" ;
         A30TTBUS_DesProveedor = "" ;
         lblTextblockttbus_fechacarga5_Jsonclick = "" ;
         A18TTBUS_RubroDesc = "" ;
         lblTextblockttbus_fechacarga4_Jsonclick = "" ;
         lblTitleidentificadores2_Jsonclick = "" ;
         lblTextblock14_Jsonclick = "" ;
         A38TTBUS_DesPosicion = "" ;
         lblTextblock11_Jsonclick = "" ;
         AV30SEC_DRE = "" ;
         lblTextblock12_Jsonclick = "" ;
         AV49TTBUS2_MotivoEnvio = "" ;
         lblTextblock16_Jsonclick = "" ;
         AV52TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         lblTextblock13_Jsonclick = "" ;
         AV50TTBUS2_Observaciones = "" ;
         lblTextblock5_Jsonclick = "" ;
         A75TTBUS_UsuarioAlta = "" ;
         lblTextblock6_Jsonclick = "" ;
         A76TTBUS_MaquinaAlta = "" ;
         Gridttbus000_identificadoresContainer = new GXWebGrid( context);
         Gridttbus000_identificadoresColumn = new GXWebColumn();
         sMode2 = "" ;
         dynIdIdentificador_Internalname = "" ;
         edtNumeroIdentificador_Internalname = "" ;
         Gridttbus000_documentacionContainer = new GXWebGrid( context);
         Gridttbus000_documentacionColumn = new GXWebColumn();
         A65DocuDesc = "" ;
         A66DocuObservaciones = "" ;
         sMode3 = "" ;
         edtDocuId_Internalname = "" ;
         edtDocuDesc_Internalname = "" ;
         edtDocuObservaciones_Internalname = "" ;
         lblTitledocumentacion_Jsonclick = "" ;
         lblTitleidentificadores_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         Z13TTBUS_FechaCarga = DateTime.MinValue ;
         Z38TTBUS_DesPosicion = "" ;
         Z75TTBUS_UsuarioAlta = "" ;
         Z76TTBUS_MaquinaAlta = "" ;
         Z12TTBUS_Descripcion = "" ;
         Z42TTBUS_NroSerie = "" ;
         AV29SEC_CRE = "" ;
         AV25mje_error = "" ;
         AV26mje_error1 = "" ;
         sMode1 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z15NumeroIdentificador = "" ;
         Z65DocuDesc = "" ;
         Z66DocuObservaciones = "" ;
         AV17Context = new SdtContext(context);
         AV31SESION = new GxWebSession( context);
         AV47TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV48TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         Z30TTBUS_DesProveedor = "" ;
         Z18TTBUS_RubroDesc = "" ;
         T000112_A11TTBUS_Id = new int[1] ;
         T000112_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         T000112_A38TTBUS_DesPosicion = new String[] {""} ;
         T000112_A75TTBUS_UsuarioAlta = new String[] {""} ;
         T000112_A76TTBUS_MaquinaAlta = new String[] {""} ;
         T000112_A12TTBUS_Descripcion = new String[] {""} ;
         T000112_A23TTBUS_Estado = new short[1] ;
         T000112_A30TTBUS_DesProveedor = new String[] {""} ;
         T000112_n30TTBUS_DesProveedor = new bool[] {false} ;
         T000112_A29TTBUS_Alquilado = new short[1] ;
         T000112_A18TTBUS_RubroDesc = new String[] {""} ;
         T000112_n18TTBUS_RubroDesc = new bool[] {false} ;
         T000112_A74TTBUS_ContDocu = new int[1] ;
         T000112_n74TTBUS_ContDocu = new bool[] {false} ;
         T000112_A42TTBUS_NroSerie = new String[] {""} ;
         T000112_n42TTBUS_NroSerie = new bool[] {false} ;
         T000112_A27TTBUS_CodProveedor = new int[1] ;
         T000112_n27TTBUS_CodProveedor = new bool[] {false} ;
         T000112_A37TTBUS_CodPosicion = new short[1] ;
         T000112_A17TTBUS_RubroBien = new short[1] ;
         T00019_A30TTBUS_DesProveedor = new String[] {""} ;
         T00019_n30TTBUS_DesProveedor = new bool[] {false} ;
         T000110_A37TTBUS_CodPosicion = new short[1] ;
         T000111_A18TTBUS_RubroDesc = new String[] {""} ;
         T000111_n18TTBUS_RubroDesc = new bool[] {false} ;
         T000113_A30TTBUS_DesProveedor = new String[] {""} ;
         T000113_n30TTBUS_DesProveedor = new bool[] {false} ;
         T000114_A37TTBUS_CodPosicion = new short[1] ;
         T000115_A18TTBUS_RubroDesc = new String[] {""} ;
         T000115_n18TTBUS_RubroDesc = new bool[] {false} ;
         T000116_A11TTBUS_Id = new int[1] ;
         T00018_A11TTBUS_Id = new int[1] ;
         T00018_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         T00018_A38TTBUS_DesPosicion = new String[] {""} ;
         T00018_A75TTBUS_UsuarioAlta = new String[] {""} ;
         T00018_A76TTBUS_MaquinaAlta = new String[] {""} ;
         T00018_A12TTBUS_Descripcion = new String[] {""} ;
         T00018_A23TTBUS_Estado = new short[1] ;
         T00018_A29TTBUS_Alquilado = new short[1] ;
         T00018_A74TTBUS_ContDocu = new int[1] ;
         T00018_n74TTBUS_ContDocu = new bool[] {false} ;
         T00018_A42TTBUS_NroSerie = new String[] {""} ;
         T00018_n42TTBUS_NroSerie = new bool[] {false} ;
         T00018_A27TTBUS_CodProveedor = new int[1] ;
         T00018_n27TTBUS_CodProveedor = new bool[] {false} ;
         T00018_A37TTBUS_CodPosicion = new short[1] ;
         T00018_A17TTBUS_RubroBien = new short[1] ;
         T000117_A11TTBUS_Id = new int[1] ;
         T000118_A11TTBUS_Id = new int[1] ;
         T000119_A11TTBUS_Id = new int[1] ;
         T000119_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         T000119_A38TTBUS_DesPosicion = new String[] {""} ;
         T000119_A75TTBUS_UsuarioAlta = new String[] {""} ;
         T000119_A76TTBUS_MaquinaAlta = new String[] {""} ;
         T000119_A12TTBUS_Descripcion = new String[] {""} ;
         T000119_A23TTBUS_Estado = new short[1] ;
         T000119_A29TTBUS_Alquilado = new short[1] ;
         T000119_A74TTBUS_ContDocu = new int[1] ;
         T000119_n74TTBUS_ContDocu = new bool[] {false} ;
         T000119_A42TTBUS_NroSerie = new String[] {""} ;
         T000119_n42TTBUS_NroSerie = new bool[] {false} ;
         T000119_A27TTBUS_CodProveedor = new int[1] ;
         T000119_n27TTBUS_CodProveedor = new bool[] {false} ;
         T000119_A37TTBUS_CodPosicion = new short[1] ;
         T000119_A17TTBUS_RubroBien = new short[1] ;
         T000121_A11TTBUS_Id = new int[1] ;
         T000124_A30TTBUS_DesProveedor = new String[] {""} ;
         T000124_n30TTBUS_DesProveedor = new bool[] {false} ;
         T000125_A18TTBUS_RubroDesc = new String[] {""} ;
         T000125_n18TTBUS_RubroDesc = new bool[] {false} ;
         T000127_A11TTBUS_Id = new int[1] ;
         T000128_A11TTBUS_Id = new int[1] ;
         T000128_A15NumeroIdentificador = new String[] {""} ;
         T000128_A14IdIdentificador = new int[1] ;
         T00016_A14IdIdentificador = new int[1] ;
         T000129_A14IdIdentificador = new int[1] ;
         T000130_A11TTBUS_Id = new int[1] ;
         T000130_A14IdIdentificador = new int[1] ;
         T00015_A11TTBUS_Id = new int[1] ;
         T00015_A15NumeroIdentificador = new String[] {""} ;
         T00015_A14IdIdentificador = new int[1] ;
         T00014_A11TTBUS_Id = new int[1] ;
         T00014_A15NumeroIdentificador = new String[] {""} ;
         T00014_A14IdIdentificador = new int[1] ;
         T000134_A11TTBUS_Id = new int[1] ;
         T000134_A14IdIdentificador = new int[1] ;
         T000135_A11TTBUS_Id = new int[1] ;
         T000135_A64DocuId = new int[1] ;
         T000135_A65DocuDesc = new String[] {""} ;
         T000135_A66DocuObservaciones = new String[] {""} ;
         T000136_A11TTBUS_Id = new int[1] ;
         T000136_A64DocuId = new int[1] ;
         T00013_A11TTBUS_Id = new int[1] ;
         T00013_A64DocuId = new int[1] ;
         T00013_A65DocuDesc = new String[] {""} ;
         T00013_A66DocuObservaciones = new String[] {""} ;
         T00012_A11TTBUS_Id = new int[1] ;
         T00012_A64DocuId = new int[1] ;
         T00012_A65DocuDesc = new String[] {""} ;
         T00012_A66DocuObservaciones = new String[] {""} ;
         T000140_A11TTBUS_Id = new int[1] ;
         T000140_A64DocuId = new int[1] ;
         Gridttbus000_identificadoresRow = new GXWebRow();
         subGridttbus000_identificadores_Linesclass = "" ;
         ROClassString = "" ;
         Gridttbus000_documentacionRow = new GXWebRow();
         subGridttbus000_documentacion_Linesclass = "" ;
         GXt_char8 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char10 = "" ;
         GXt_char9 = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         l12TTBUS_Descripcion = "" ;
         T000141_A12TTBUS_Descripcion = new String[] {""} ;
         T000142_A14IdIdentificador = new int[1] ;
         T000142_A21TTBUS5_DescIdentificador = new String[] {""} ;
         T000142_n21TTBUS5_DescIdentificador = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         T000143_A37TTBUS_CodPosicion = new short[1] ;
         T000144_A14IdIdentificador = new int[1] ;
         GXt_char11 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus000__default(),
            new Object[][] {
                new Object[] {
               T00012_A11TTBUS_Id, T00012_A64DocuId, T00012_A65DocuDesc, T00012_A66DocuObservaciones
               }
               , new Object[] {
               T00013_A11TTBUS_Id, T00013_A64DocuId, T00013_A65DocuDesc, T00013_A66DocuObservaciones
               }
               , new Object[] {
               T00014_A11TTBUS_Id, T00014_A15NumeroIdentificador, T00014_A14IdIdentificador
               }
               , new Object[] {
               T00015_A11TTBUS_Id, T00015_A15NumeroIdentificador, T00015_A14IdIdentificador
               }
               , new Object[] {
               T00016_A14IdIdentificador
               }
               , new Object[] {
               T00017_A11TTBUS_Id, T00017_A13TTBUS_FechaCarga, T00017_A38TTBUS_DesPosicion, T00017_A75TTBUS_UsuarioAlta, T00017_A76TTBUS_MaquinaAlta, T00017_A12TTBUS_Descripcion, T00017_A23TTBUS_Estado, T00017_A29TTBUS_Alquilado, T00017_A74TTBUS_ContDocu, T00017_n74TTBUS_ContDocu,
               T00017_A42TTBUS_NroSerie, T00017_n42TTBUS_NroSerie, T00017_A27TTBUS_CodProveedor, T00017_n27TTBUS_CodProveedor, T00017_A37TTBUS_CodPosicion, T00017_A17TTBUS_RubroBien
               }
               , new Object[] {
               T00018_A11TTBUS_Id, T00018_A13TTBUS_FechaCarga, T00018_A38TTBUS_DesPosicion, T00018_A75TTBUS_UsuarioAlta, T00018_A76TTBUS_MaquinaAlta, T00018_A12TTBUS_Descripcion, T00018_A23TTBUS_Estado, T00018_A29TTBUS_Alquilado, T00018_A74TTBUS_ContDocu, T00018_n74TTBUS_ContDocu,
               T00018_A42TTBUS_NroSerie, T00018_n42TTBUS_NroSerie, T00018_A27TTBUS_CodProveedor, T00018_n27TTBUS_CodProveedor, T00018_A37TTBUS_CodPosicion, T00018_A17TTBUS_RubroBien
               }
               , new Object[] {
               T00019_A30TTBUS_DesProveedor, T00019_n30TTBUS_DesProveedor
               }
               , new Object[] {
               T000110_A37TTBUS_CodPosicion
               }
               , new Object[] {
               T000111_A18TTBUS_RubroDesc, T000111_n18TTBUS_RubroDesc
               }
               , new Object[] {
               T000112_A11TTBUS_Id, T000112_A13TTBUS_FechaCarga, T000112_A38TTBUS_DesPosicion, T000112_A75TTBUS_UsuarioAlta, T000112_A76TTBUS_MaquinaAlta, T000112_A12TTBUS_Descripcion, T000112_A23TTBUS_Estado, T000112_A30TTBUS_DesProveedor, T000112_n30TTBUS_DesProveedor, T000112_A29TTBUS_Alquilado,
               T000112_A18TTBUS_RubroDesc, T000112_n18TTBUS_RubroDesc, T000112_A74TTBUS_ContDocu, T000112_n74TTBUS_ContDocu, T000112_A42TTBUS_NroSerie, T000112_n42TTBUS_NroSerie, T000112_A27TTBUS_CodProveedor, T000112_n27TTBUS_CodProveedor, T000112_A37TTBUS_CodPosicion, T000112_A17TTBUS_RubroBien
               }
               , new Object[] {
               T000113_A30TTBUS_DesProveedor, T000113_n30TTBUS_DesProveedor
               }
               , new Object[] {
               T000114_A37TTBUS_CodPosicion
               }
               , new Object[] {
               T000115_A18TTBUS_RubroDesc, T000115_n18TTBUS_RubroDesc
               }
               , new Object[] {
               T000116_A11TTBUS_Id
               }
               , new Object[] {
               T000117_A11TTBUS_Id
               }
               , new Object[] {
               T000118_A11TTBUS_Id
               }
               , new Object[] {
               T000119_A11TTBUS_Id, T000119_A13TTBUS_FechaCarga, T000119_A38TTBUS_DesPosicion, T000119_A75TTBUS_UsuarioAlta, T000119_A76TTBUS_MaquinaAlta, T000119_A12TTBUS_Descripcion, T000119_A23TTBUS_Estado, T000119_A29TTBUS_Alquilado, T000119_A74TTBUS_ContDocu, T000119_n74TTBUS_ContDocu,
               T000119_A42TTBUS_NroSerie, T000119_n42TTBUS_NroSerie, T000119_A27TTBUS_CodProveedor, T000119_n27TTBUS_CodProveedor, T000119_A37TTBUS_CodPosicion, T000119_A17TTBUS_RubroBien
               }
               , new Object[] {
               }
               , new Object[] {
               T000121_A11TTBUS_Id
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000124_A30TTBUS_DesProveedor, T000124_n30TTBUS_DesProveedor
               }
               , new Object[] {
               T000125_A18TTBUS_RubroDesc, T000125_n18TTBUS_RubroDesc
               }
               , new Object[] {
               }
               , new Object[] {
               T000127_A11TTBUS_Id
               }
               , new Object[] {
               T000128_A11TTBUS_Id, T000128_A15NumeroIdentificador, T000128_A14IdIdentificador
               }
               , new Object[] {
               T000129_A14IdIdentificador
               }
               , new Object[] {
               T000130_A11TTBUS_Id, T000130_A14IdIdentificador
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000134_A11TTBUS_Id, T000134_A14IdIdentificador
               }
               , new Object[] {
               T000135_A11TTBUS_Id, T000135_A64DocuId, T000135_A65DocuDesc, T000135_A66DocuObservaciones
               }
               , new Object[] {
               T000136_A11TTBUS_Id, T000136_A64DocuId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000140_A11TTBUS_Id, T000140_A64DocuId
               }
               , new Object[] {
               T000141_A12TTBUS_Descripcion
               }
               , new Object[] {
               T000142_A14IdIdentificador, T000142_A21TTBUS5_DescIdentificador, T000142_n21TTBUS5_DescIdentificador
               }
               , new Object[] {
               T000143_A37TTBUS_CodPosicion
               }
               , new Object[] {
               T000144_A14IdIdentificador
               }
            }
         );
         Z23TTBUS_Estado = 1 ;
      }

      private short wcpOAV34TTBUS_CodPosicion ;
      private short wcpOAV38TTBUS_Estado ;
      private short wcpOAV16consulta ;
      private short GxWebError ;
      private short A37TTBUS_CodPosicion ;
      private short A17TTBUS_RubroBien ;
      private short nRC_Gridttbus000_identificadores ;
      private short nGXsfl_109_idx=1 ;
      private short nRC_Gridttbus000_documentacion ;
      private short nGXsfl_118_idx=1 ;
      private short AV34TTBUS_CodPosicion ;
      private short AV38TTBUS_Estado ;
      private short AV16consulta ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A29TTBUS_Alquilado ;
      private short subGridttbus000_identificadores_Backcolorstyle ;
      private short subGridttbus000_identificadores_Collapsed ;
      private short nBlankRcdCount2 ;
      private short nRcdExists_2 ;
      private short RcdFound2 ;
      private short nIsMod_2 ;
      private short nBlankRcdUsr2 ;
      private short subGridttbus000_documentacion_Backcolorstyle ;
      private short subGridttbus000_documentacion_Collapsed ;
      private short nBlankRcdCount3 ;
      private short nRcdExists_3 ;
      private short RcdFound3 ;
      private short nIsMod_3 ;
      private short nBlankRcdUsr3 ;
      private short Z23TTBUS_Estado ;
      private short Z29TTBUS_Alquilado ;
      private short Z37TTBUS_CodPosicion ;
      private short Z17TTBUS_RubroBien ;
      private short A23TTBUS_Estado ;
      private short AV18dup_cont ;
      private short AV19dup_hw ;
      private short Gx_BScreen ;
      private short AV14cod_error ;
      private short AV15cod_error1 ;
      private short RcdFound1 ;
      private short nRcdDeleted_2 ;
      private short nRcdDeleted_3 ;
      private short AV23id_docu ;
      private short AV20estado ;
      private short AV7band ;
      private short GXt_int7 ;
      private short GX_JID ;
      private short subGridttbus000_identificadores_Backstyle ;
      private short subGridttbus000_documentacion_Backstyle ;
      private short gxajaxcallmode ;
      private short i23TTBUS_Estado ;
      private int wcpOAV39TTBUS_Id ;
      private int A11TTBUS_Id ;
      private int A14IdIdentificador ;
      private int A27TTBUS_CodProveedor ;
      private int AV39TTBUS_Id ;
      private int trnEnded ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int edtTTBUS_Id_Enabled ;
      private int edtTTBUS_Descripcion_Enabled ;
      private int edtTTBUS_NroSerie_Enabled ;
      private int edtTTBUS_FechaCarga_Enabled ;
      private int edtTTBUS_CodProveedor_Enabled ;
      private int imgprompt_27_Visible ;
      private int edtTTBUS_DesProveedor_Enabled ;
      private int edtTTBUS_RubroBien_Enabled ;
      private int imgprompt_17_Visible ;
      private int edtTTBUS_RubroDesc_Enabled ;
      private int edtTTBUS_CodPosicion_Enabled ;
      private int imgprompt_37_Visible ;
      private int edtTTBUS_DesPosicion_Enabled ;
      private int edtavSec_dre_Enabled ;
      private int edtavTtbus2_motivoenvio_Enabled ;
      private int edtavTtbus2_plazorecepcion_Enabled ;
      private int edtavTtbus2_observaciones_Enabled ;
      private int edtTTBUS_UsuarioAlta_Enabled ;
      private int edtTTBUS_MaquinaAlta_Enabled ;
      private int edtNumeroIdentificador_Enabled ;
      private int B74TTBUS_ContDocu ;
      private int A74TTBUS_ContDocu ;
      private int fRowAdded ;
      private int A64DocuId ;
      private int edtDocuId_Enabled ;
      private int edtDocuDesc_Enabled ;
      private int edtDocuObservaciones_Enabled ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int Z11TTBUS_Id ;
      private int Z74TTBUS_ContDocu ;
      private int Z27TTBUS_CodProveedor ;
      private int O74TTBUS_ContDocu ;
      private int GRIDTTBUS000_IDENTIFICADORES_nFirstRecordOnPage ;
      private int GRIDTTBUS000_DOCUMENTACION_nFirstRecordOnPage ;
      private int Z14IdIdentificador ;
      private int s74TTBUS_ContDocu ;
      private int Z64DocuId ;
      private int subGridttbus000_identificadores_Backcolor ;
      private int subGridttbus000_identificadores_Allbackcolor ;
      private int subGridttbus000_documentacion_Backcolor ;
      private int subGridttbus000_documentacion_Allbackcolor ;
      private int defedtDocuId_Enabled ;
      private int defdynIdIdentificador_Enabled ;
      private int i74TTBUS_ContDocu ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV28pSEC_CRE ;
      private String wcpOAV32SISTEMA ;
      private String wcpOAV51USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV51USUARIO ;
      private String sGXsfl_109_idx="0001" ;
      private String sGXsfl_118_idx="0001" ;
      private String AV28pSEC_CRE ;
      private String AV32SISTEMA ;
      private String chkTTBUS_Alquilado_Internalname ;
      private String GXCCtl ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String tblTable7_Internalname ;
      private String TempTags ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus_descripcion2_Internalname ;
      private String lblTextblockttbus_descripcion2_Jsonclick ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Id_Jsonclick ;
      private String lblTextblockttbus_descripcion_Internalname ;
      private String lblTextblockttbus_descripcion_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtTTBUS_NroSerie_Internalname ;
      private String edtTTBUS_NroSerie_Jsonclick ;
      private String lblTextblockttbus_fechacarga_Internalname ;
      private String lblTextblockttbus_fechacarga_Jsonclick ;
      private String edtTTBUS_FechaCarga_Internalname ;
      private String edtTTBUS_FechaCarga_Jsonclick ;
      private String lblTextblockttbus_fechacarga2_Internalname ;
      private String lblTextblockttbus_fechacarga2_Jsonclick ;
      private String edtTTBUS_CodProveedor_Internalname ;
      private String edtTTBUS_CodProveedor_Jsonclick ;
      private String imgprompt_27_Internalname ;
      private String imgprompt_27_Link ;
      private String edtTTBUS_DesProveedor_Internalname ;
      private String A30TTBUS_DesProveedor ;
      private String edtTTBUS_DesProveedor_Jsonclick ;
      private String lblTextblockttbus_fechacarga5_Internalname ;
      private String lblTextblockttbus_fechacarga5_Jsonclick ;
      private String edtTTBUS_RubroBien_Internalname ;
      private String edtTTBUS_RubroBien_Jsonclick ;
      private String imgprompt_17_Internalname ;
      private String imgprompt_17_Link ;
      private String edtTTBUS_RubroDesc_Internalname ;
      private String A18TTBUS_RubroDesc ;
      private String edtTTBUS_RubroDesc_Jsonclick ;
      private String lblTextblockttbus_fechacarga4_Internalname ;
      private String lblTextblockttbus_fechacarga4_Jsonclick ;
      private String lblTitleidentificadores2_Internalname ;
      private String lblTitleidentificadores2_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String edtTTBUS_CodPosicion_Internalname ;
      private String edtTTBUS_CodPosicion_Jsonclick ;
      private String imgprompt_37_Internalname ;
      private String imgprompt_37_Link ;
      private String edtTTBUS_DesPosicion_Internalname ;
      private String A38TTBUS_DesPosicion ;
      private String edtTTBUS_DesPosicion_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavSec_dre_Internalname ;
      private String AV30SEC_DRE ;
      private String edtavSec_dre_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtavTtbus2_motivoenvio_Internalname ;
      private String edtavTtbus2_motivoenvio_Jsonclick ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String edtavTtbus2_plazorecepcion_Internalname ;
      private String edtavTtbus2_plazorecepcion_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String edtavTtbus2_observaciones_Internalname ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtTTBUS_UsuarioAlta_Internalname ;
      private String A75TTBUS_UsuarioAlta ;
      private String edtTTBUS_UsuarioAlta_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtTTBUS_MaquinaAlta_Internalname ;
      private String A76TTBUS_MaquinaAlta ;
      private String edtTTBUS_MaquinaAlta_Jsonclick ;
      private String sMode2 ;
      private String dynIdIdentificador_Internalname ;
      private String edtNumeroIdentificador_Internalname ;
      private String sMode3 ;
      private String edtDocuId_Internalname ;
      private String edtDocuDesc_Internalname ;
      private String edtDocuObservaciones_Internalname ;
      private String tblTable5_Internalname ;
      private String lblTitledocumentacion_Internalname ;
      private String lblTitledocumentacion_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTitleidentificadores_Internalname ;
      private String lblTitleidentificadores_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String Z38TTBUS_DesPosicion ;
      private String Z75TTBUS_UsuarioAlta ;
      private String Z76TTBUS_MaquinaAlta ;
      private String AV29SEC_CRE ;
      private String AV25mje_error ;
      private String AV26mje_error1 ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z30TTBUS_DesProveedor ;
      private String Z18TTBUS_RubroDesc ;
      private String subGridttbus000_identificadores_Class ;
      private String subGridttbus000_identificadores_Linesclass ;
      private String dynIdIdentificador_Jsonclick ;
      private String ROClassString ;
      private String edtNumeroIdentificador_Jsonclick ;
      private String subGridttbus000_documentacion_Class ;
      private String subGridttbus000_documentacion_Linesclass ;
      private String edtDocuId_Jsonclick ;
      private String GXt_char8 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char10 ;
      private String GXt_char9 ;
      private String subGridttbus000_identificadores_Internalname ;
      private String subGridttbus000_documentacion_Internalname ;
      private String gxwrpcisep ;
      private String GXt_char11 ;
      private DateTime AV47TTBUS2_FechaEnvio ;
      private DateTime AV48TTBUS2_FechaRecepcion ;
      private DateTime A13TTBUS_FechaCarga ;
      private DateTime AV52TTBUS2_PlazoRecepcion ;
      private DateTime Z13TTBUS_FechaCarga ;
      private bool entryPointCalled ;
      private bool n27TTBUS_CodProveedor ;
      private bool wbErr ;
      private bool n74TTBUS_ContDocu ;
      private bool n42TTBUS_NroSerie ;
      private bool n30TTBUS_DesProveedor ;
      private bool n18TTBUS_RubroDesc ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String A15NumeroIdentificador ;
      private String A12TTBUS_Descripcion ;
      private String A42TTBUS_NroSerie ;
      private String AV49TTBUS2_MotivoEnvio ;
      private String AV50TTBUS2_Observaciones ;
      private String A65DocuDesc ;
      private String A66DocuObservaciones ;
      private String Z12TTBUS_Descripcion ;
      private String Z42TTBUS_NroSerie ;
      private String Z15NumeroIdentificador ;
      private String Z65DocuDesc ;
      private String Z66DocuObservaciones ;
      private String l12TTBUS_Descripcion ;
      private GxWebSession AV31SESION ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridttbus000_identificadoresContainer ;
      private GXWebGrid Gridttbus000_documentacionContainer ;
      private GXWebRow Gridttbus000_identificadoresRow ;
      private GXWebRow Gridttbus000_documentacionRow ;
      private GXWebColumn Gridttbus000_identificadoresColumn ;
      private GXWebColumn Gridttbus000_documentacionColumn ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private String aP1_Gx_mode ;
      private short aP2_TTBUS_CodPosicion ;
      private String aP3_pSEC_CRE ;
      private short aP4_TTBUS_Estado ;
      private short aP5_consulta ;
      private String aP6_SISTEMA ;
      private String aP7_USUARIO ;
      private GXCheckbox chkTTBUS_Alquilado ;
      private GXCombobox dynIdIdentificador ;
      private IDataStoreProvider pr_default ;
      private int[] T000112_A11TTBUS_Id ;
      private DateTime[] T000112_A13TTBUS_FechaCarga ;
      private String[] T000112_A38TTBUS_DesPosicion ;
      private String[] T000112_A75TTBUS_UsuarioAlta ;
      private String[] T000112_A76TTBUS_MaquinaAlta ;
      private String[] T000112_A12TTBUS_Descripcion ;
      private short[] T000112_A23TTBUS_Estado ;
      private String[] T000112_A30TTBUS_DesProveedor ;
      private bool[] T000112_n30TTBUS_DesProveedor ;
      private short[] T000112_A29TTBUS_Alquilado ;
      private String[] T000112_A18TTBUS_RubroDesc ;
      private bool[] T000112_n18TTBUS_RubroDesc ;
      private int[] T000112_A74TTBUS_ContDocu ;
      private bool[] T000112_n74TTBUS_ContDocu ;
      private String[] T000112_A42TTBUS_NroSerie ;
      private bool[] T000112_n42TTBUS_NroSerie ;
      private int[] T000112_A27TTBUS_CodProveedor ;
      private bool[] T000112_n27TTBUS_CodProveedor ;
      private short[] T000112_A37TTBUS_CodPosicion ;
      private short[] T000112_A17TTBUS_RubroBien ;
      private String[] T00019_A30TTBUS_DesProveedor ;
      private bool[] T00019_n30TTBUS_DesProveedor ;
      private short[] T000110_A37TTBUS_CodPosicion ;
      private String[] T000111_A18TTBUS_RubroDesc ;
      private bool[] T000111_n18TTBUS_RubroDesc ;
      private String[] T000113_A30TTBUS_DesProveedor ;
      private bool[] T000113_n30TTBUS_DesProveedor ;
      private short[] T000114_A37TTBUS_CodPosicion ;
      private String[] T000115_A18TTBUS_RubroDesc ;
      private bool[] T000115_n18TTBUS_RubroDesc ;
      private int[] T000116_A11TTBUS_Id ;
      private int[] T00018_A11TTBUS_Id ;
      private DateTime[] T00018_A13TTBUS_FechaCarga ;
      private String[] T00018_A38TTBUS_DesPosicion ;
      private String[] T00018_A75TTBUS_UsuarioAlta ;
      private String[] T00018_A76TTBUS_MaquinaAlta ;
      private String[] T00018_A12TTBUS_Descripcion ;
      private short[] T00018_A23TTBUS_Estado ;
      private short[] T00018_A29TTBUS_Alquilado ;
      private int[] T00018_A74TTBUS_ContDocu ;
      private bool[] T00018_n74TTBUS_ContDocu ;
      private String[] T00018_A42TTBUS_NroSerie ;
      private bool[] T00018_n42TTBUS_NroSerie ;
      private int[] T00018_A27TTBUS_CodProveedor ;
      private bool[] T00018_n27TTBUS_CodProveedor ;
      private short[] T00018_A37TTBUS_CodPosicion ;
      private short[] T00018_A17TTBUS_RubroBien ;
      private int[] T000117_A11TTBUS_Id ;
      private int[] T000118_A11TTBUS_Id ;
      private int[] T000119_A11TTBUS_Id ;
      private DateTime[] T000119_A13TTBUS_FechaCarga ;
      private String[] T000119_A38TTBUS_DesPosicion ;
      private String[] T000119_A75TTBUS_UsuarioAlta ;
      private String[] T000119_A76TTBUS_MaquinaAlta ;
      private String[] T000119_A12TTBUS_Descripcion ;
      private short[] T000119_A23TTBUS_Estado ;
      private short[] T000119_A29TTBUS_Alquilado ;
      private int[] T000119_A74TTBUS_ContDocu ;
      private bool[] T000119_n74TTBUS_ContDocu ;
      private String[] T000119_A42TTBUS_NroSerie ;
      private bool[] T000119_n42TTBUS_NroSerie ;
      private int[] T000119_A27TTBUS_CodProveedor ;
      private bool[] T000119_n27TTBUS_CodProveedor ;
      private short[] T000119_A37TTBUS_CodPosicion ;
      private short[] T000119_A17TTBUS_RubroBien ;
      private int[] T000121_A11TTBUS_Id ;
      private String[] T000124_A30TTBUS_DesProveedor ;
      private bool[] T000124_n30TTBUS_DesProveedor ;
      private String[] T000125_A18TTBUS_RubroDesc ;
      private bool[] T000125_n18TTBUS_RubroDesc ;
      private int[] T000127_A11TTBUS_Id ;
      private int[] T000128_A11TTBUS_Id ;
      private String[] T000128_A15NumeroIdentificador ;
      private int[] T000128_A14IdIdentificador ;
      private int[] T00016_A14IdIdentificador ;
      private int[] T000129_A14IdIdentificador ;
      private int[] T000130_A11TTBUS_Id ;
      private int[] T000130_A14IdIdentificador ;
      private int[] T00015_A11TTBUS_Id ;
      private String[] T00015_A15NumeroIdentificador ;
      private int[] T00015_A14IdIdentificador ;
      private int[] T00014_A11TTBUS_Id ;
      private String[] T00014_A15NumeroIdentificador ;
      private int[] T00014_A14IdIdentificador ;
      private int[] T000134_A11TTBUS_Id ;
      private int[] T000134_A14IdIdentificador ;
      private int[] T000135_A11TTBUS_Id ;
      private int[] T000135_A64DocuId ;
      private String[] T000135_A65DocuDesc ;
      private String[] T000135_A66DocuObservaciones ;
      private int[] T000136_A11TTBUS_Id ;
      private int[] T000136_A64DocuId ;
      private int[] T00013_A11TTBUS_Id ;
      private int[] T00013_A64DocuId ;
      private String[] T00013_A65DocuDesc ;
      private String[] T00013_A66DocuObservaciones ;
      private int[] T00012_A11TTBUS_Id ;
      private int[] T00012_A64DocuId ;
      private String[] T00012_A65DocuDesc ;
      private String[] T00012_A66DocuObservaciones ;
      private int[] T000140_A11TTBUS_Id ;
      private int[] T000140_A64DocuId ;
      private String[] T000141_A12TTBUS_Descripcion ;
      private int[] T000142_A14IdIdentificador ;
      private String[] T000142_A21TTBUS5_DescIdentificador ;
      private bool[] T000142_n21TTBUS5_DescIdentificador ;
      private short[] T000143_A37TTBUS_CodPosicion ;
      private int[] T000144_A14IdIdentificador ;
      private int[] T00017_A11TTBUS_Id ;
      private DateTime[] T00017_A13TTBUS_FechaCarga ;
      private String[] T00017_A38TTBUS_DesPosicion ;
      private String[] T00017_A75TTBUS_UsuarioAlta ;
      private String[] T00017_A76TTBUS_MaquinaAlta ;
      private String[] T00017_A12TTBUS_Descripcion ;
      private short[] T00017_A23TTBUS_Estado ;
      private short[] T00017_A29TTBUS_Alquilado ;
      private int[] T00017_A74TTBUS_ContDocu ;
      private String[] T00017_A42TTBUS_NroSerie ;
      private int[] T00017_A27TTBUS_CodProveedor ;
      private short[] T00017_A37TTBUS_CodPosicion ;
      private short[] T00017_A17TTBUS_RubroBien ;
      private bool[] T00017_n74TTBUS_ContDocu ;
      private bool[] T00017_n42TTBUS_NroSerie ;
      private bool[] T00017_n27TTBUS_CodProveedor ;
      private GXWebForm Form ;
      private SdtContext AV17Context ;
   }

   public class ttbus000__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new UpdateCursor(def[29])
         ,new UpdateCursor(def[30])
         ,new UpdateCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new UpdateCursor(def[35])
         ,new UpdateCursor(def[36])
         ,new UpdateCursor(def[37])
         ,new ForEachCursor(def[38])
         ,new ForEachCursor(def[39])
         ,new ForEachCursor(def[40])
         ,new ForEachCursor(def[41])
         ,new ForEachCursor(def[42])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@TTBUS_CodProveedor",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@TTBUS_CodProveedor",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          new Object[] {"@TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000117 ;
          prmT000117 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000118 ;
          prmT000118 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000119 ;
          prmT000119 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000120 ;
          prmT000120 = new Object[] {
          new Object[] {"@TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS_DesPosicion",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS_UsuarioAlta",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS_MaquinaAlta",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_Alquilado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_ContDocu",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS_NroSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@TTBUS_CodProveedor",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000121 ;
          prmT000121 = new Object[] {
          } ;
          Object[] prmT000122 ;
          prmT000122 = new Object[] {
          new Object[] {"@TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS_DesPosicion",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS_UsuarioAlta",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS_MaquinaAlta",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_Alquilado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_ContDocu",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS_NroSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@TTBUS_CodProveedor",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS_RubroBien",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000123 ;
          prmT000123 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000126 ;
          prmT000126 = new Object[] {
          new Object[] {"@TTBUS_ContDocu",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000127 ;
          prmT000127 = new Object[] {
          } ;
          Object[] prmT000128 ;
          prmT000128 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000129 ;
          prmT000129 = new Object[] {
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000130 ;
          prmT000130 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000131 ;
          prmT000131 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@NumeroIdentificador",SqlDbType.VarChar,80,0} ,
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000132 ;
          prmT000132 = new Object[] {
          new Object[] {"@NumeroIdentificador",SqlDbType.VarChar,80,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000133 ;
          prmT000133 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000134 ;
          prmT000134 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000135 ;
          prmT000135 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@DocuId",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000136 ;
          prmT000136 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@DocuId",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@DocuId",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@DocuId",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000137 ;
          prmT000137 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@DocuId",SqlDbType.Int,8,0} ,
          new Object[] {"@DocuDesc",SqlDbType.VarChar,80,0} ,
          new Object[] {"@DocuObservaciones",SqlDbType.VarChar,200,0}
          } ;
          Object[] prmT000138 ;
          prmT000138 = new Object[] {
          new Object[] {"@DocuDesc",SqlDbType.VarChar,80,0} ,
          new Object[] {"@DocuObservaciones",SqlDbType.VarChar,200,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@DocuId",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000139 ;
          prmT000139 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@DocuId",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000140 ;
          prmT000140 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000141 ;
          prmT000141 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmT000142 ;
          prmT000142 = new Object[] {
          } ;
          Object[] prmT000124 ;
          prmT000124 = new Object[] {
          new Object[] {"@TTBUS_CodProveedor",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000125 ;
          prmT000125 = new Object[] {
          new Object[] {"@TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000143 ;
          prmT000143 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000144 ;
          prmT000144 = new Object[] {
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT [TTBUS_Id], [DocuId], [DocuDesc], [DocuObservaciones] FROM [TTBUS000Documentacion] WITH (UPDLOCK) WHERE [TTBUS_Id] = @TTBUS_Id AND [DocuId] = @DocuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
             ,new CursorDef("T00013", "SELECT [TTBUS_Id], [DocuId], [DocuDesc], [DocuObservaciones] FROM [TTBUS000Documentacion] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id AND [DocuId] = @DocuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
             ,new CursorDef("T00014", "SELECT [TTBUS_Id], [NumeroIdentificador], [IdIdentificador] AS IdIdentificador FROM [TTBUS000Identificadores] WITH (UPDLOCK) WHERE [TTBUS_Id] = @TTBUS_Id AND [IdIdentificador] = @IdIdentificador ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
             ,new CursorDef("T00015", "SELECT [TTBUS_Id], [NumeroIdentificador], [IdIdentificador] AS IdIdentificador FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id AND [IdIdentificador] = @IdIdentificador ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,false )
             ,new CursorDef("T00016", "SELECT [TTBUS5_IdIdentificador] AS IdIdentificador FROM [TTBUS005] WITH (NOLOCK) WHERE [TTBUS5_IdIdentificador] = @IdIdentificador ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,false )
             ,new CursorDef("T00017", "SELECT [TTBUS_Id], [TTBUS_FechaCarga], [TTBUS_DesPosicion], [TTBUS_UsuarioAlta], [TTBUS_MaquinaAlta], [TTBUS_Descripcion], [TTBUS_Estado], [TTBUS_Alquilado], [TTBUS_ContDocu], [TTBUS_NroSerie], [TTBUS_CodProveedor] AS TTBUS_CodProveedor, [TTBUS_CodPosicion] AS TTBUS_CodPosicion, [TTBUS_RubroBien] AS TTBUS_RubroBien FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1,0,true,false )
             ,new CursorDef("T00018", "SELECT [TTBUS_Id], [TTBUS_FechaCarga], [TTBUS_DesPosicion], [TTBUS_UsuarioAlta], [TTBUS_MaquinaAlta], [TTBUS_Descripcion], [TTBUS_Estado], [TTBUS_Alquilado], [TTBUS_ContDocu], [TTBUS_NroSerie], [TTBUS_CodProveedor] AS TTBUS_CodProveedor, [TTBUS_CodPosicion] AS TTBUS_CodPosicion, [TTBUS_RubroBien] AS TTBUS_RubroBien FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,false )
             ,new CursorDef("T00019", "SELECT [PV_DESC] AS TTBUS_DesProveedor FROM [M124FPROV] WITH (NOLOCK) WHERE [PV_NPRO] = @TTBUS_CodProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1,0,true,false )
             ,new CursorDef("T000110", "SELECT [TTBUS7_Pos] AS TTBUS_CodPosicion FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1,0,true,false )
             ,new CursorDef("T000111", "SELECT [RBR_DES] AS TTBUS_RubroDesc FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @TTBUS_RubroBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,1,0,true,false )
             ,new CursorDef("T000112", "SELECT TM1.[TTBUS_Id], TM1.[TTBUS_FechaCarga], TM1.[TTBUS_DesPosicion], TM1.[TTBUS_UsuarioAlta], TM1.[TTBUS_MaquinaAlta], TM1.[TTBUS_Descripcion], TM1.[TTBUS_Estado], T2.[PV_DESC] AS TTBUS_DesProveedor, TM1.[TTBUS_Alquilado], T3.[RBR_DES] AS TTBUS_RubroDesc, TM1.[TTBUS_ContDocu], TM1.[TTBUS_NroSerie], TM1.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, TM1.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, TM1.[TTBUS_RubroBien] AS TTBUS_RubroBien FROM (([TTBUS000] TM1 WITH (NOLOCK) LEFT JOIN [M124FPROV] T2 WITH (NOLOCK) ON T2.[PV_NPRO] = TM1.[TTBUS_CodProveedor]) INNER JOIN [BUS002] T3 WITH (NOLOCK) ON T3.[RBR_COD] = TM1.[TTBUS_RubroBien]) WHERE TM1.[TTBUS_Id] = @TTBUS_Id ORDER BY TM1.[TTBUS_Id]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000112,100,0,true,false )
             ,new CursorDef("T000113", "SELECT [PV_DESC] AS TTBUS_DesProveedor FROM [M124FPROV] WITH (NOLOCK) WHERE [PV_NPRO] = @TTBUS_CodProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT000113,1,0,true,false )
             ,new CursorDef("T000114", "SELECT [TTBUS7_Pos] AS TTBUS_CodPosicion FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,1,0,true,false )
             ,new CursorDef("T000115", "SELECT [RBR_DES] AS TTBUS_RubroDesc FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @TTBUS_RubroBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1,0,true,false )
             ,new CursorDef("T000116", "SELECT [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,1,0,true,false )
             ,new CursorDef("T000117", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE ( [TTBUS_Id] > @TTBUS_Id) ORDER BY [TTBUS_Id]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000117,1,0,true,true )
             ,new CursorDef("T000118", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE ( [TTBUS_Id] < @TTBUS_Id) ORDER BY [TTBUS_Id] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,1,0,true,true )
             ,new CursorDef("T000119", "SELECT [TTBUS_Id], [TTBUS_FechaCarga], [TTBUS_DesPosicion], [TTBUS_UsuarioAlta], [TTBUS_MaquinaAlta], [TTBUS_Descripcion], [TTBUS_Estado], [TTBUS_Alquilado], [TTBUS_ContDocu], [TTBUS_NroSerie], [TTBUS_CodProveedor] AS TTBUS_CodProveedor, [TTBUS_CodPosicion] AS TTBUS_CodPosicion, [TTBUS_RubroBien] AS TTBUS_RubroBien FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT000119,1,0,true,false )
             ,new CursorDef("T000120", "INSERT INTO [TTBUS000] ([TTBUS_FechaCarga], [TTBUS_DesPosicion], [TTBUS_UsuarioAlta], [TTBUS_MaquinaAlta], [TTBUS_Descripcion], [TTBUS_Estado], [TTBUS_Alquilado], [TTBUS_ContDocu], [TTBUS_NroSerie], [TTBUS_CodProveedor], [TTBUS_CodPosicion], [TTBUS_RubroBien], [TTBUS_FechaBaja], [TTBUS_MotivoBaja], [TTBUS_UsuarioBaja], [TTBUS_MaquinaBaja]) VALUES (@TTBUS_FechaCarga, @TTBUS_DesPosicion, @TTBUS_UsuarioAlta, @TTBUS_MaquinaAlta, @TTBUS_Descripcion, @TTBUS_Estado, @TTBUS_Alquilado, @TTBUS_ContDocu, @TTBUS_NroSerie, @TTBUS_CodProveedor, @TTBUS_CodPosicion, @TTBUS_RubroBien, convert( DATETIME, '17530101', 112 ), '', '', '')", GxErrorMask.GX_NOMASK,prmT000120)
             ,new CursorDef("T000121", "SELECT Ident_Current('[TTBUS000]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000121,1,0,true,false )
             ,new CursorDef("T000122", "UPDATE [TTBUS000] SET [TTBUS_FechaCarga]=@TTBUS_FechaCarga, [TTBUS_DesPosicion]=@TTBUS_DesPosicion, [TTBUS_UsuarioAlta]=@TTBUS_UsuarioAlta, [TTBUS_MaquinaAlta]=@TTBUS_MaquinaAlta, [TTBUS_Descripcion]=@TTBUS_Descripcion, [TTBUS_Estado]=@TTBUS_Estado, [TTBUS_Alquilado]=@TTBUS_Alquilado, [TTBUS_ContDocu]=@TTBUS_ContDocu, [TTBUS_NroSerie]=@TTBUS_NroSerie, [TTBUS_CodProveedor]=@TTBUS_CodProveedor, [TTBUS_CodPosicion]=@TTBUS_CodPosicion, [TTBUS_RubroBien]=@TTBUS_RubroBien  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK,prmT000122)
             ,new CursorDef("T000123", "DELETE FROM [TTBUS000]  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK,prmT000123)
             ,new CursorDef("T000124", "SELECT [PV_DESC] AS TTBUS_DesProveedor FROM [M124FPROV] WITH (NOLOCK) WHERE [PV_NPRO] = @TTBUS_CodProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT000124,1,0,true,false )
             ,new CursorDef("T000125", "SELECT [RBR_DES] AS TTBUS_RubroDesc FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @TTBUS_RubroBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000125,1,0,true,false )
             ,new CursorDef("T000126", "UPDATE [TTBUS000] SET [TTBUS_ContDocu]=@TTBUS_ContDocu  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK,prmT000126)
             ,new CursorDef("T000127", "SELECT [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) ORDER BY [TTBUS_Id]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000127,100,0,true,false )
             ,new CursorDef("T000128", "SELECT [TTBUS_Id], [NumeroIdentificador], [IdIdentificador] AS IdIdentificador FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id and [IdIdentificador] = @IdIdentificador ORDER BY [TTBUS_Id], [IdIdentificador] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000128,11,0,true,false )
             ,new CursorDef("T000129", "SELECT [TTBUS5_IdIdentificador] AS IdIdentificador FROM [TTBUS005] WITH (NOLOCK) WHERE [TTBUS5_IdIdentificador] = @IdIdentificador ",true, GxErrorMask.GX_NOMASK, false, this,prmT000129,1,0,true,false )
             ,new CursorDef("T000130", "SELECT [TTBUS_Id], [IdIdentificador] AS IdIdentificador FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id AND [IdIdentificador] = @IdIdentificador ",true, GxErrorMask.GX_NOMASK, false, this,prmT000130,1,0,true,false )
             ,new CursorDef("T000131", "INSERT INTO [TTBUS000Identificadores] ([TTBUS_Id], [NumeroIdentificador], [IdIdentificador]) VALUES (@TTBUS_Id, @NumeroIdentificador, @IdIdentificador)", GxErrorMask.GX_NOMASK,prmT000131)
             ,new CursorDef("T000132", "UPDATE [TTBUS000Identificadores] SET [NumeroIdentificador]=@NumeroIdentificador  WHERE [TTBUS_Id] = @TTBUS_Id AND [IdIdentificador] = @IdIdentificador", GxErrorMask.GX_NOMASK,prmT000132)
             ,new CursorDef("T000133", "DELETE FROM [TTBUS000Identificadores]  WHERE [TTBUS_Id] = @TTBUS_Id AND [IdIdentificador] = @IdIdentificador", GxErrorMask.GX_NOMASK,prmT000133)
             ,new CursorDef("T000134", "SELECT [TTBUS_Id], [IdIdentificador] AS IdIdentificador FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ORDER BY [TTBUS_Id], [IdIdentificador] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000134,11,0,true,false )
             ,new CursorDef("T000135", "SELECT [TTBUS_Id], [DocuId], [DocuDesc], [DocuObservaciones] FROM [TTBUS000Documentacion] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id and [DocuId] = @DocuId ORDER BY [TTBUS_Id], [DocuId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000135,4,0,true,false )
             ,new CursorDef("T000136", "SELECT [TTBUS_Id], [DocuId] FROM [TTBUS000Documentacion] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id AND [DocuId] = @DocuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000136,1,0,true,false )
             ,new CursorDef("T000137", "INSERT INTO [TTBUS000Documentacion] ([TTBUS_Id], [DocuId], [DocuDesc], [DocuObservaciones]) VALUES (@TTBUS_Id, @DocuId, @DocuDesc, @DocuObservaciones)", GxErrorMask.GX_NOMASK,prmT000137)
             ,new CursorDef("T000138", "UPDATE [TTBUS000Documentacion] SET [DocuDesc]=@DocuDesc, [DocuObservaciones]=@DocuObservaciones  WHERE [TTBUS_Id] = @TTBUS_Id AND [DocuId] = @DocuId", GxErrorMask.GX_NOMASK,prmT000138)
             ,new CursorDef("T000139", "DELETE FROM [TTBUS000Documentacion]  WHERE [TTBUS_Id] = @TTBUS_Id AND [DocuId] = @DocuId", GxErrorMask.GX_NOMASK,prmT000139)
             ,new CursorDef("T000140", "SELECT [TTBUS_Id], [DocuId] FROM [TTBUS000Documentacion] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ORDER BY [TTBUS_Id], [DocuId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000140,4,0,true,false )
             ,new CursorDef("T000141", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000141,0,0,true,false )
             ,new CursorDef("T000142", "SELECT [TTBUS5_IdIdentificador] AS IdIdentificador, [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) ORDER BY [TTBUS5_DescIdentificador] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000142,0,0,true,false )
             ,new CursorDef("T000143", "SELECT [TTBUS7_Pos] AS TTBUS_CodPosicion FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ",true, GxErrorMask.GX_NOMASK, false, this,prmT000143,1,0,true,false )
             ,new CursorDef("T000144", "SELECT [TTBUS5_IdIdentificador] AS IdIdentificador FROM [TTBUS005] WITH (NOLOCK) WHERE [TTBUS5_IdIdentificador] = @IdIdentificador ",true, GxErrorMask.GX_NOMASK, false, this,prmT000144,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((int[]) buf[8])[0] = rslt.getInt(9) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(9);
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(10);
                ((int[]) buf[12])[0] = rslt.getInt(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((short[]) buf[14])[0] = rslt.getShort(12) ;
                ((short[]) buf[15])[0] = rslt.getShort(13) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((int[]) buf[8])[0] = rslt.getInt(9) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(9);
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(10);
                ((int[]) buf[12])[0] = rslt.getInt(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((short[]) buf[14])[0] = rslt.getShort(12) ;
                ((short[]) buf[15])[0] = rslt.getShort(13) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 30) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((short[]) buf[9])[0] = rslt.getShort(9) ;
                ((String[]) buf[10])[0] = rslt.getString(10, 30) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(10);
                ((int[]) buf[12])[0] = rslt.getInt(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((String[]) buf[14])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(12);
                ((int[]) buf[16])[0] = rslt.getInt(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((short[]) buf[18])[0] = rslt.getShort(14) ;
                ((short[]) buf[19])[0] = rslt.getShort(15) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 16 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((int[]) buf[8])[0] = rslt.getInt(9) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(9);
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(10);
                ((int[]) buf[12])[0] = rslt.getInt(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((short[]) buf[14])[0] = rslt.getShort(12) ;
                ((short[]) buf[15])[0] = rslt.getShort(13) ;
                break;
             case 19 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 25 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 26 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 27 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 28 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 32 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 33 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 34 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 38 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 39 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 40 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 41 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 42 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 18 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 10 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(10, (int)parms[12]);
                }
                stmt.SetParameter(11, (short)parms[13]);
                stmt.SetParameter(12, (short)parms[14]);
                break;
             case 20 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 10 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(10, (int)parms[12]);
                }
                stmt.SetParameter(11, (short)parms[13]);
                stmt.SetParameter(12, (short)parms[14]);
                stmt.SetParameter(13, (int)parms[15]);
                break;
             case 21 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 22 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 24 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 26 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 27 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 28 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 29 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 30 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 31 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 32 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 33 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 34 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 35 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 36 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 37 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 38 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 39 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 41 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 42 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
