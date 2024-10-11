using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

using HplEdgeClient.Types;

namespace HplEdgeClient.Responses
{
  public class FindCompressedAccountsReturn
  {
    [JsonProperty("compressedAccount")]
    public List<CompressedAccount> CompressedAccount;

    public FindCompressedAccountsReturn() { }

  }

  public class FetchProofsReturn
  {
    [JsonProperty("proof")]
    public List<Proof> Proof;

    public FetchProofsReturn() { }

  }

  public class FindAccountsReturn
  {
    [JsonProperty("account")]
    public List<Account> Account;

    public FindAccountsReturn() { }

  }

  public class SendTransactionBundlesReturn
  {
    [JsonProperty("sendTransactionBundles")]
    public List<TransactionBundleResponse> SendTransactionBundles;

    public SendTransactionBundlesReturn() { }

  }

  public class SignWithShadowSignerAndSendTransactionBundlesReturn
  {
    [JsonProperty("signWithShadowSignerAndSendTransactionBundles")]
    public List<TransactionBundleResponse> SignWithShadowSignerAndSendTransactionBundles;

    public SignWithShadowSignerAndSendTransactionBundlesReturn() { }

  }

  public class SendBulkTransactionsReturn
  {
    [JsonProperty("sendBulkTransactions")]
    public List<TransactionResponse> SendBulkTransactions;

    public SendBulkTransactionsReturn() { }

  }

  public class SignWithShadowSignerAndSendBulkTransactionsReturn
  {
    [JsonProperty("signWithShadowSignerAndSendBulkTransactions")]
    public List<TransactionResponse> SignWithShadowSignerAndSendBulkTransactions;

    public SignWithShadowSignerAndSendBulkTransactionsReturn() { }

  }

  public class AuthRequestReturn
  {
    [JsonProperty("authRequest")]
    public AuthResponse AuthRequest;

    public AuthRequestReturn() { }

  }

  public class AuthConfirmReturn
  {
    [JsonProperty("authConfirm")]
    public AuthConfirmed AuthConfirm;

    public AuthConfirmReturn() { }

  }

  public class FindGlobalReturn
  {
    [JsonProperty("global")]
    public Global Global;

    public FindGlobalReturn() { }

  }

  public class FindProjectsReturn
  {
    [JsonProperty("project")]
    public List<Project> Project;

    public FindProjectsReturn() { }

  }

  public class FindDelegateAuthorityReturn
  {
    [JsonProperty("delegateAuthority")]
    public List<DelegateAuthority> DelegateAuthority;

    public FindDelegateAuthorityReturn() { }

  }

  public class FindUsersReturn
  {
    [JsonProperty("user")]
    public List<User> User;

    public FindUsersReturn() { }

  }

  public class FindProfilesReturn
  {
    [JsonProperty("profile")]
    public List<Profile> Profile;

    public FindProfilesReturn() { }

  }

  public class CreateNewUserTransactionReturn
  {
    [JsonProperty("createNewUserTransaction")]
    public Transaction CreateNewUserTransaction;

    public CreateNewUserTransactionReturn() { }

  }

  public class CreateNewUserBulkTransactionReturn
  {
    [JsonProperty("createNewUserBulkTransaction")]
    public Transactions CreateNewUserBulkTransaction;

    public CreateNewUserBulkTransactionReturn() { }

  }

  public class CreateUpdateUserTransactionReturn
  {
    [JsonProperty("createUpdateUserTransaction")]
    public Transaction CreateUpdateUserTransaction;

    public CreateUpdateUserTransactionReturn() { }

  }

  public class CreateCreateProjectTransactionReturn
  {
    [JsonProperty("createCreateProjectTransaction")]
    public CreateCreateProjectTransactionResponse CreateCreateProjectTransaction;

    public CreateCreateProjectTransactionReturn() { }

  }

  public class CreateChangeProjectDriverTransactionReturn
  {
    [JsonProperty("createChangeProjectDriverTransaction")]
    public Transaction CreateChangeProjectDriverTransaction;

    public CreateChangeProjectDriverTransactionReturn() { }

  }

  public class CreateCreateDelegateAuthorityTransactionReturn
  {
    [JsonProperty("createCreateDelegateAuthorityTransaction")]
    public Transaction CreateCreateDelegateAuthorityTransaction;

    public CreateCreateDelegateAuthorityTransactionReturn() { }

  }

  public class CreateModifyDelegationTransactionReturn
  {
    [JsonProperty("createModifyDelegationTransaction")]
    public Transaction CreateModifyDelegationTransaction;

    public CreateModifyDelegationTransactionReturn() { }

  }

  public class CreateCreateProfilesTreeTransactionReturn
  {
    [JsonProperty("createCreateProfilesTreeTransaction")]
    public TreeSetupResponse CreateCreateProfilesTreeTransaction;

    public CreateCreateProfilesTreeTransactionReturn() { }

  }

  public class CreateNewProfileTransactionReturn
  {
    [JsonProperty("createNewProfileTransaction")]
    public Transaction CreateNewProfileTransaction;

    public CreateNewProfileTransactionReturn() { }

  }

  public class CreateUpdateProfileTransactionReturn
  {
    [JsonProperty("createUpdateProfileTransaction")]
    public Transaction CreateUpdateProfileTransaction;

    public CreateUpdateProfileTransactionReturn() { }

  }

  public class CreateNewUserWithProfileTransactionReturn
  {
    [JsonProperty("createNewUserWithProfileTransaction")]
    public Transaction CreateNewUserWithProfileTransaction;

    public CreateNewUserWithProfileTransactionReturn() { }

  }

  public class FindAssemblerConfigReturn
  {
    [JsonProperty("assemblerConfig")]
    public List<AssemblerConfig> AssemblerConfig;

    public FindAssemblerConfigReturn() { }

  }

  public class FindCharacterTraitsReturn
  {
    [JsonProperty("characterTrait")]
    public List<CharacterTrait> CharacterTrait;

    public FindCharacterTraitsReturn() { }

  }

  public class FindCharacterModelsReturn
  {
    [JsonProperty("characterModel")]
    public List<CharacterModel> CharacterModel;

    public FindCharacterModelsReturn() { }

  }

  public class FindCharactersReturn
  {
    [JsonProperty("character")]
    public List<Character> Character;

    public FindCharactersReturn() { }

  }

  public class FetchCharacterHistoryReturn
  {
    [JsonProperty("characterHistory")]
    public List<CharacterHistory> CharacterHistory;

    public FetchCharacterHistoryReturn() { }

  }

  public class CreateCreateAssemblerConfigTransactionReturn
  {
    [JsonProperty("createCreateAssemblerConfigTransaction")]
    public CreateAssemblerConfigTransactionResponse CreateCreateAssemblerConfigTransaction;

    public CreateCreateAssemblerConfigTransactionReturn() { }

  }

  public class CreateAddCharacterTraitsTransactionsReturn
  {
    [JsonProperty("createAddCharacterTraitsTransactions")]
    public Transactions CreateAddCharacterTraitsTransactions;

    public CreateAddCharacterTraitsTransactionsReturn() { }

  }

  public class CreateRemoveCharacterTraitsTransactionsReturn
  {
    [JsonProperty("createRemoveCharacterTraitsTransactions")]
    public Transactions CreateRemoveCharacterTraitsTransactions;

    public CreateRemoveCharacterTraitsTransactionsReturn() { }

  }

  public class CreateCreateCharacterModelTransactionReturn
  {
    [JsonProperty("createCreateCharacterModelTransaction")]
    public CreateCharacterModelTransactionResponse CreateCreateCharacterModelTransaction;

    public CreateCreateCharacterModelTransactionReturn() { }

  }

  public class CreateCreateCharactersTreeTransactionReturn
  {
    [JsonProperty("createCreateCharactersTreeTransaction")]
    public TreeSetupResponse CreateCreateCharactersTreeTransaction;

    public CreateCreateCharactersTreeTransactionReturn() { }

  }

  public class CreateAssembleCharacterTransactionReturn
  {
    [JsonProperty("createAssembleCharacterTransaction")]
    public Transaction CreateAssembleCharacterTransaction;

    public CreateAssembleCharacterTransactionReturn() { }

  }

  public class CreateUpdateCharacterTraitsTransactionReturn
  {
    [JsonProperty("createUpdateCharacterTraitsTransaction")]
    public Transaction CreateUpdateCharacterTraitsTransaction;

    public CreateUpdateCharacterTraitsTransactionReturn() { }

  }

  public class CreatePopulateCharacterTransactionReturn
  {
    [JsonProperty("createPopulateCharacterTransaction")]
    public Transaction CreatePopulateCharacterTransaction;

    public CreatePopulateCharacterTransactionReturn() { }

  }

  public class CreateWrapAssetsToCharacterTransactionsReturn
  {
    [JsonProperty("createWrapAssetsToCharacterTransactions")]
    public Transactions CreateWrapAssetsToCharacterTransactions;

    public CreateWrapAssetsToCharacterTransactionsReturn() { }

  }

  public class CreateUnwrapAssetsFromCharacterTransactionsReturn
  {
    [JsonProperty("createUnwrapAssetsFromCharacterTransactions")]
    public Transactions CreateUnwrapAssetsFromCharacterTransactions;

    public CreateUnwrapAssetsFromCharacterTransactionsReturn() { }

  }

  public class FindStakingPoolsReturn
  {
    [JsonProperty("stakingPools")]
    public List<StakingPool> StakingPools;

    public FindStakingPoolsReturn() { }

  }

  public class FindStakersReturn
  {
    [JsonProperty("stakers")]
    public List<Staker> Stakers;

    public FindStakersReturn() { }

  }

  public class FindMultipliersReturn
  {
    [JsonProperty("multipliers")]
    public List<Multipliers> Multipliers;

    public FindMultipliersReturn() { }

  }

  public class CreateCreateStakingPoolTransactionReturn
  {
    [JsonProperty("createCreateStakingPoolTransaction")]
    public CreateCreateStakingPoolTransactionResponse CreateCreateStakingPoolTransaction;

    public CreateCreateStakingPoolTransactionReturn() { }

  }

  public class CreateUpdateStakingPoolTransactionReturn
  {
    [JsonProperty("createUpdateStakingPoolTransaction")]
    public Transaction CreateUpdateStakingPoolTransaction;

    public CreateUpdateStakingPoolTransactionReturn() { }

  }

  public class CreateInitMultipliersTransactionReturn
  {
    [JsonProperty("createInitMultipliersTransaction")]
    public CreateInitMultipliersTransactionResponse CreateInitMultipliersTransaction;

    public CreateInitMultipliersTransactionReturn() { }

  }

  public class CreateAddMultiplierTransactionReturn
  {
    [JsonProperty("createAddMultiplierTransaction")]
    public Transaction CreateAddMultiplierTransaction;

    public CreateAddMultiplierTransactionReturn() { }

  }

  public class CreateStakeCharactersTransactionsReturn
  {
    [JsonProperty("createStakeCharactersTransactions")]
    public Transactions CreateStakeCharactersTransactions;

    public CreateStakeCharactersTransactionsReturn() { }

  }

  public class CreateClaimStakingRewardsTransactionsReturn
  {
    [JsonProperty("createClaimStakingRewardsTransactions")]
    public Transactions CreateClaimStakingRewardsTransactions;

    public CreateClaimStakingRewardsTransactionsReturn() { }

  }

  public class CreateUnstakeCharactersTransactionsReturn
  {
    [JsonProperty("createUnstakeCharactersTransactions")]
    public Transactions CreateUnstakeCharactersTransactions;

    public CreateUnstakeCharactersTransactionsReturn() { }

  }

  public class FindMissionsReturn
  {
    [JsonProperty("mission")]
    public List<Mission> Mission;

    public FindMissionsReturn() { }

  }

  public class FindMissionPoolsReturn
  {
    [JsonProperty("missionPool")]
    public List<MissionPool> MissionPool;

    public FindMissionPoolsReturn() { }

  }

  public class CreateCreateMissionPoolTransactionReturn
  {
    [JsonProperty("createCreateMissionPoolTransaction")]
    public CreateCreateMissionPoolTransactionResponse CreateCreateMissionPoolTransaction;

    public CreateCreateMissionPoolTransactionReturn() { }

  }

  public class CreateUpdateMissionPoolTransactionReturn
  {
    [JsonProperty("createUpdateMissionPoolTransaction")]
    public CreateUpdateMissionPoolTransactionResponse CreateUpdateMissionPoolTransaction;

    public CreateUpdateMissionPoolTransactionReturn() { }

  }

  public class CreateCreateMissionTransactionReturn
  {
    [JsonProperty("createCreateMissionTransaction")]
    public CreateCreateMissionTransactionResponse CreateCreateMissionTransaction;

    public CreateCreateMissionTransactionReturn() { }

  }

  public class CreateUpdateMissionTransactionReturn
  {
    [JsonProperty("createUpdateMissionTransaction")]
    public Transaction CreateUpdateMissionTransaction;

    public CreateUpdateMissionTransactionReturn() { }

  }

  public class CreateSendCharactersOnMissionTransactionReturn
  {
    [JsonProperty("createSendCharactersOnMissionTransaction")]
    public Transactions CreateSendCharactersOnMissionTransaction;

    public CreateSendCharactersOnMissionTransactionReturn() { }

  }

  public class CreateRecallCharactersTransactionReturn
  {
    [JsonProperty("createRecallCharactersTransaction")]
    public Transactions CreateRecallCharactersTransaction;

    public CreateRecallCharactersTransactionReturn() { }

  }

  public class FindResourcesReturn
  {
    [JsonProperty("resources")]
    public List<Resource> Resources;

    public FindResourcesReturn() { }

  }

  public class FindResourcesBalanceReturn
  {
    [JsonProperty("resourcesBalance")]
    public List<ResourceBalance> ResourcesBalance;

    public FindResourcesBalanceReturn() { }

  }

  public class FindFaucetsReturn
  {
    [JsonProperty("faucets")]
    public List<Faucet> Faucets;

    public FindFaucetsReturn() { }

  }

  public class FindRecipesReturn
  {
    [JsonProperty("recipes")]
    public List<Recipe> Recipes;

    public FindRecipesReturn() { }

  }

  public class FindHoldingsReturn
  {
    [JsonProperty("holdings")]
    public List<Holding> Holdings;

    public FindHoldingsReturn() { }

  }

  public class CreateCreateNewResourceTransactionReturn
  {
    [JsonProperty("createCreateNewResourceTransaction")]
    public CreateInitResourceTransactionResponse CreateCreateNewResourceTransaction;

    public CreateCreateNewResourceTransactionReturn() { }

  }

  public class CreateImportFungibleResourceTransactionReturn
  {
    [JsonProperty("createImportFungibleResourceTransaction")]
    public CreateInitResourceTransactionResponse CreateImportFungibleResourceTransaction;

    public CreateImportFungibleResourceTransactionReturn() { }

  }

  public class CreateExportFungibleResourceTransactionReturn
  {
    [JsonProperty("createExportFungibleResourceTransaction")]
    public Transaction CreateExportFungibleResourceTransaction;

    public CreateExportFungibleResourceTransactionReturn() { }

  }

  public class CreateCreateNewResourceTreeTransactionReturn
  {
    [JsonProperty("createCreateNewResourceTreeTransaction")]
    public TreeSetupResponse CreateCreateNewResourceTreeTransaction;

    public CreateCreateNewResourceTreeTransactionReturn() { }

  }

  public class CreateMintResourceTransactionReturn
  {
    [JsonProperty("createMintResourceTransaction")]
    public Transaction CreateMintResourceTransaction;

    public CreateMintResourceTransactionReturn() { }

  }

  public class CreateBurnResourceTransactionReturn
  {
    [JsonProperty("createBurnResourceTransaction")]
    public Transaction CreateBurnResourceTransaction;

    public CreateBurnResourceTransactionReturn() { }

  }

  public class CreateTransferResourceTransactionReturn
  {
    [JsonProperty("createTransferResourceTransaction")]
    public Transaction CreateTransferResourceTransaction;

    public CreateTransferResourceTransactionReturn() { }

  }

  public class CreateCreateWrapHoldingTransactionReturn
  {
    [JsonProperty("createCreateWrapHoldingTransaction")]
    public Transaction CreateCreateWrapHoldingTransaction;

    public CreateCreateWrapHoldingTransactionReturn() { }

  }

  public class CreateCreateUnwrapHoldingTransactionReturn
  {
    [JsonProperty("createCreateUnwrapHoldingTransaction")]
    public Transaction CreateCreateUnwrapHoldingTransaction;

    public CreateCreateUnwrapHoldingTransactionReturn() { }

  }

  public class CreateInitializeRecipeTransactionReturn
  {
    [JsonProperty("createInitializeRecipeTransaction")]
    public CreateInitializeRecipeTransactionResponse CreateInitializeRecipeTransaction;

    public CreateInitializeRecipeTransactionReturn() { }

  }

  public class CreateAddIngredientsTransactionReturn
  {
    [JsonProperty("createAddIngredientsTransaction")]
    public Transactions CreateAddIngredientsTransaction;

    public CreateAddIngredientsTransactionReturn() { }

  }

  public class CreateRemoveIngredientsTransactionReturn
  {
    [JsonProperty("createRemoveIngredientsTransaction")]
    public Transactions CreateRemoveIngredientsTransaction;

    public CreateRemoveIngredientsTransactionReturn() { }

  }

  public class CreateInitializeFaucetTransactionReturn
  {
    [JsonProperty("createInitializeFaucetTransaction")]
    public CreateInitializeFaucetTransactionResponse CreateInitializeFaucetTransaction;

    public CreateInitializeFaucetTransactionReturn() { }

  }

  public class CreateClaimFaucetTransactionReturn
  {
    [JsonProperty("createClaimFaucetTransaction")]
    public Transaction CreateClaimFaucetTransaction;

    public CreateClaimFaucetTransactionReturn() { }

  }

  public class CreateInitCookingProcessTransactionsReturn
  {
    [JsonProperty("createInitCookingProcessTransactions")]
    public Transactions CreateInitCookingProcessTransactions;

    public CreateInitCookingProcessTransactionsReturn() { }

  }

  public class CreateInitializeBadgeCriteriaTransactionReturn
  {
    [JsonProperty("createInitializeBadgeCriteriaTransaction")]
    public Transaction CreateInitializeBadgeCriteriaTransaction;

    public CreateInitializeBadgeCriteriaTransactionReturn() { }

  }

  public class CreateClaimBadgeCriteriaTransactionReturn
  {
    [JsonProperty("createClaimBadgeCriteriaTransaction")]
    public Transaction CreateClaimBadgeCriteriaTransaction;

    public CreateClaimBadgeCriteriaTransactionReturn() { }

  }

  public class CreateUpdateBadgeCriteriaTransactionReturn
  {
    [JsonProperty("createUpdateBadgeCriteriaTransaction")]
    public Transaction CreateUpdateBadgeCriteriaTransaction;

    public CreateUpdateBadgeCriteriaTransactionReturn() { }

  }

}

