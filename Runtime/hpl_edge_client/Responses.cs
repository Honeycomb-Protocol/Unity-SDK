using Newtonsoft.Json;
using System.Collections.Generic;

using HplEdgeClient.Types;

namespace HplEdgeClient.Responses
{
  public class FindCompressedAccountsReturn
  {
    [JsonProperty("compressedAccount")]
    public List<CompressedAccount> CompressedAccount { get; set; }

    public FindCompressedAccountsReturn() { }

  }

  public class FetchProofsReturn
  {
    [JsonProperty("proof")]
    public List<Proof> Proof { get; set; }

    public FetchProofsReturn() { }

  }

  public class FindAccountsReturn
  {
    [JsonProperty("account")]
    public List<Account> Account { get; set; }

    public FindAccountsReturn() { }

  }

  public class SendTransactionBundlesReturn
  {
    [JsonProperty("sendTransactionBundles")]
    public List<TransactionBundleResponse> SendTransactionBundles { get; set; }

    public SendTransactionBundlesReturn() { }

  }

  public class SignWithShadowSignerAndSendTransactionBundlesReturn
  {
    [JsonProperty("signWithShadowSignerAndSendTransactionBundles")]
    public List<TransactionBundleResponse> SignWithShadowSignerAndSendTransactionBundles { get; set; }

    public SignWithShadowSignerAndSendTransactionBundlesReturn() { }

  }

  public class SendBulkTransactionsReturn
  {
    [JsonProperty("sendBulkTransactions")]
    public List<TransactionResponse> SendBulkTransactions { get; set; }

    public SendBulkTransactionsReturn() { }

  }

  public class SignWithShadowSignerAndSendBulkTransactionsReturn
  {
    [JsonProperty("signWithShadowSignerAndSendBulkTransactions")]
    public List<TransactionResponse> SignWithShadowSignerAndSendBulkTransactions { get; set; }

    public SignWithShadowSignerAndSendBulkTransactionsReturn() { }

  }

  public class AuthRequestReturn
  {
    [JsonProperty("authRequest")]
    public AuthResponse AuthRequest { get; set; }

    public AuthRequestReturn() { }

  }

  public class AuthConfirmReturn
  {
    [JsonProperty("authConfirm")]
    public AuthConfirmed AuthConfirm { get; set; }

    public AuthConfirmReturn() { }

  }

  public class FindGlobalReturn
  {
    [JsonProperty("global")]
    public Global Global { get; set; }

    public FindGlobalReturn() { }

  }

  public class FindProjectsReturn
  {
    [JsonProperty("project")]
    public List<Project> Project { get; set; }

    public FindProjectsReturn() { }

  }

  public class FindDelegateAuthorityReturn
  {
    [JsonProperty("delegateAuthority")]
    public List<DelegateAuthority> DelegateAuthority { get; set; }

    public FindDelegateAuthorityReturn() { }

  }

  public class FindUsersReturn
  {
    [JsonProperty("user")]
    public List<User> User { get; set; }

    public FindUsersReturn() { }

  }

  public class FindProfilesReturn
  {
    [JsonProperty("profile")]
    public List<Profile> Profile { get; set; }

    public FindProfilesReturn() { }

  }

  public class CreateNewUserTransactionReturn
  {
    [JsonProperty("createNewUserTransaction")]
    public Transaction CreateNewUserTransaction { get; set; }

    public CreateNewUserTransactionReturn() { }

  }

  public class CreateNewUserBulkTransactionReturn
  {
    [JsonProperty("createNewUserBulkTransaction")]
    public Transactions CreateNewUserBulkTransaction { get; set; }

    public CreateNewUserBulkTransactionReturn() { }

  }

  public class CreateUpdateUserTransactionReturn
  {
    [JsonProperty("createUpdateUserTransaction")]
    public Transaction CreateUpdateUserTransaction { get; set; }

    public CreateUpdateUserTransactionReturn() { }

  }

  public class CreateCreateProjectTransactionReturn
  {
    [JsonProperty("createCreateProjectTransaction")]
    public CreateCreateProjectTransactionResponse CreateCreateProjectTransaction { get; set; }

    public CreateCreateProjectTransactionReturn() { }

  }

  public class CreateChangeProjectDriverTransactionReturn
  {
    [JsonProperty("createChangeProjectDriverTransaction")]
    public Transaction CreateChangeProjectDriverTransaction { get; set; }

    public CreateChangeProjectDriverTransactionReturn() { }

  }

  public class CreateCreateDelegateAuthorityTransactionReturn
  {
    [JsonProperty("createCreateDelegateAuthorityTransaction")]
    public Transaction CreateCreateDelegateAuthorityTransaction { get; set; }

    public CreateCreateDelegateAuthorityTransactionReturn() { }

  }

  public class CreateModifyDelegationTransactionReturn
  {
    [JsonProperty("createModifyDelegationTransaction")]
    public Transaction CreateModifyDelegationTransaction { get; set; }

    public CreateModifyDelegationTransactionReturn() { }

  }

  public class CreateCreateProfilesTreeTransactionReturn
  {
    [JsonProperty("createCreateProfilesTreeTransaction")]
    public TreeSetupResponse CreateCreateProfilesTreeTransaction { get; set; }

    public CreateCreateProfilesTreeTransactionReturn() { }

  }

  public class CreateNewProfileTransactionReturn
  {
    [JsonProperty("createNewProfileTransaction")]
    public Transaction CreateNewProfileTransaction { get; set; }

    public CreateNewProfileTransactionReturn() { }

  }

  public class CreateUpdateProfileTransactionReturn
  {
    [JsonProperty("createUpdateProfileTransaction")]
    public Transaction CreateUpdateProfileTransaction { get; set; }

    public CreateUpdateProfileTransactionReturn() { }

  }

  public class CreateUpdatePlatformDataTransactionReturn
  {
    [JsonProperty("createUpdatePlatformDataTransaction")]
    public Transaction CreateUpdatePlatformDataTransaction { get; set; }

    public CreateUpdatePlatformDataTransactionReturn() { }

  }

  public class CreateNewUserWithProfileTransactionReturn
  {
    [JsonProperty("createNewUserWithProfileTransaction")]
    public Transaction CreateNewUserWithProfileTransaction { get; set; }

    public CreateNewUserWithProfileTransactionReturn() { }

  }

  public class FindAssemblerConfigReturn
  {
    [JsonProperty("assemblerConfig")]
    public List<AssemblerConfig> AssemblerConfig { get; set; }

    public FindAssemblerConfigReturn() { }

  }

  public class FindCharacterTraitsReturn
  {
    [JsonProperty("characterTrait")]
    public List<CharacterTrait> CharacterTrait { get; set; }

    public FindCharacterTraitsReturn() { }

  }

  public class FindCharacterModelsReturn
  {
    [JsonProperty("characterModel")]
    public List<CharacterModel> CharacterModel { get; set; }

    public FindCharacterModelsReturn() { }

  }

  public class FindCharactersReturn
  {
    [JsonProperty("character")]
    public List<Character> Character { get; set; }

    public FindCharactersReturn() { }

  }

  public class FetchCharacterHistoryReturn
  {
    [JsonProperty("characterHistory")]
    public List<CharacterHistory> CharacterHistory { get; set; }

    public FetchCharacterHistoryReturn() { }

  }

  public class CreateCreateAssemblerConfigTransactionReturn
  {
    [JsonProperty("createCreateAssemblerConfigTransaction")]
    public CreateAssemblerConfigTransactionResponse CreateCreateAssemblerConfigTransaction { get; set; }

    public CreateCreateAssemblerConfigTransactionReturn() { }

  }

  public class CreateAddCharacterTraitsTransactionsReturn
  {
    [JsonProperty("createAddCharacterTraitsTransactions")]
    public Transactions CreateAddCharacterTraitsTransactions { get; set; }

    public CreateAddCharacterTraitsTransactionsReturn() { }

  }

  public class CreateRemoveCharacterTraitsTransactionsReturn
  {
    [JsonProperty("createRemoveCharacterTraitsTransactions")]
    public Transactions CreateRemoveCharacterTraitsTransactions { get; set; }

    public CreateRemoveCharacterTraitsTransactionsReturn() { }

  }

  public class CreateCreateCharacterModelTransactionReturn
  {
    [JsonProperty("createCreateCharacterModelTransaction")]
    public CreateCharacterModelTransactionResponse CreateCreateCharacterModelTransaction { get; set; }

    public CreateCreateCharacterModelTransactionReturn() { }

  }

  public class CreateCreateCharactersTreeTransactionReturn
  {
    [JsonProperty("createCreateCharactersTreeTransaction")]
    public TreeSetupResponse CreateCreateCharactersTreeTransaction { get; set; }

    public CreateCreateCharactersTreeTransactionReturn() { }

  }

  public class CreateAssembleCharacterTransactionReturn
  {
    [JsonProperty("createAssembleCharacterTransaction")]
    public Transaction CreateAssembleCharacterTransaction { get; set; }

    public CreateAssembleCharacterTransactionReturn() { }

  }

  public class CreateUpdateCharacterTraitsTransactionReturn
  {
    [JsonProperty("createUpdateCharacterTraitsTransaction")]
    public Transaction CreateUpdateCharacterTraitsTransaction { get; set; }

    public CreateUpdateCharacterTraitsTransactionReturn() { }

  }

  public class CreatePopulateCharacterTransactionReturn
  {
    [JsonProperty("createPopulateCharacterTransaction")]
    public Transaction CreatePopulateCharacterTransaction { get; set; }

    public CreatePopulateCharacterTransactionReturn() { }

  }

  public class CreateWrapAssetsToCharacterTransactionsReturn
  {
    [JsonProperty("createWrapAssetsToCharacterTransactions")]
    public Transactions CreateWrapAssetsToCharacterTransactions { get; set; }

    public CreateWrapAssetsToCharacterTransactionsReturn() { }

  }

  public class CreateUnwrapAssetsFromCharacterTransactionsReturn
  {
    [JsonProperty("createUnwrapAssetsFromCharacterTransactions")]
    public Transactions CreateUnwrapAssetsFromCharacterTransactions { get; set; }

    public CreateUnwrapAssetsFromCharacterTransactionsReturn() { }

  }

  public class CreateEquipResourceOnCharacterTransactionReturn
  {
    [JsonProperty("createEquipResourceOnCharacterTransaction")]
    public Transaction CreateEquipResourceOnCharacterTransaction { get; set; }

    public CreateEquipResourceOnCharacterTransactionReturn() { }

  }

  public class CreateDismountResourceOnCharacterTransactionReturn
  {
    [JsonProperty("createDismountResourceOnCharacterTransaction")]
    public Transaction CreateDismountResourceOnCharacterTransaction { get; set; }

    public CreateDismountResourceOnCharacterTransactionReturn() { }

  }

  public class FindStakingPoolsReturn
  {
    [JsonProperty("stakingPools")]
    public List<StakingPool> StakingPools { get; set; }

    public FindStakingPoolsReturn() { }

  }

  public class FindStakersReturn
  {
    [JsonProperty("stakers")]
    public List<Staker> Stakers { get; set; }

    public FindStakersReturn() { }

  }

  public class FindMultipliersReturn
  {
    [JsonProperty("multipliers")]
    public List<Multipliers> Multipliers { get; set; }

    public FindMultipliersReturn() { }

  }

  public class CreateCreateStakingPoolTransactionReturn
  {
    [JsonProperty("createCreateStakingPoolTransaction")]
    public CreateCreateStakingPoolTransactionResponse CreateCreateStakingPoolTransaction { get; set; }

    public CreateCreateStakingPoolTransactionReturn() { }

  }

  public class CreateUpdateStakingPoolTransactionReturn
  {
    [JsonProperty("createUpdateStakingPoolTransaction")]
    public Transaction CreateUpdateStakingPoolTransaction { get; set; }

    public CreateUpdateStakingPoolTransactionReturn() { }

  }

  public class CreateInitMultipliersTransactionReturn
  {
    [JsonProperty("createInitMultipliersTransaction")]
    public CreateInitMultipliersTransactionResponse CreateInitMultipliersTransaction { get; set; }

    public CreateInitMultipliersTransactionReturn() { }

  }

  public class CreateAddMultiplierTransactionReturn
  {
    [JsonProperty("createAddMultiplierTransaction")]
    public Transaction CreateAddMultiplierTransaction { get; set; }

    public CreateAddMultiplierTransactionReturn() { }

  }

  public class CreateStakeCharactersTransactionsReturn
  {
    [JsonProperty("createStakeCharactersTransactions")]
    public Transactions CreateStakeCharactersTransactions { get; set; }

    public CreateStakeCharactersTransactionsReturn() { }

  }

  public class CreateClaimStakingRewardsTransactionsReturn
  {
    [JsonProperty("createClaimStakingRewardsTransactions")]
    public Transactions CreateClaimStakingRewardsTransactions { get; set; }

    public CreateClaimStakingRewardsTransactionsReturn() { }

  }

  public class CreateUnstakeCharactersTransactionsReturn
  {
    [JsonProperty("createUnstakeCharactersTransactions")]
    public Transactions CreateUnstakeCharactersTransactions { get; set; }

    public CreateUnstakeCharactersTransactionsReturn() { }

  }

  public class FindMissionsReturn
  {
    [JsonProperty("mission")]
    public List<Mission> Mission { get; set; }

    public FindMissionsReturn() { }

  }

  public class FindMissionPoolsReturn
  {
    [JsonProperty("missionPool")]
    public List<MissionPool> MissionPool { get; set; }

    public FindMissionPoolsReturn() { }

  }

  public class CreateCreateMissionPoolTransactionReturn
  {
    [JsonProperty("createCreateMissionPoolTransaction")]
    public CreateCreateMissionPoolTransactionResponse CreateCreateMissionPoolTransaction { get; set; }

    public CreateCreateMissionPoolTransactionReturn() { }

  }

  public class CreateUpdateMissionPoolTransactionReturn
  {
    [JsonProperty("createUpdateMissionPoolTransaction")]
    public CreateUpdateMissionPoolTransactionResponse CreateUpdateMissionPoolTransaction { get; set; }

    public CreateUpdateMissionPoolTransactionReturn() { }

  }

  public class CreateCreateMissionTransactionReturn
  {
    [JsonProperty("createCreateMissionTransaction")]
    public CreateCreateMissionTransactionResponse CreateCreateMissionTransaction { get; set; }

    public CreateCreateMissionTransactionReturn() { }

  }

  public class CreateUpdateMissionTransactionReturn
  {
    [JsonProperty("createUpdateMissionTransaction")]
    public Transaction CreateUpdateMissionTransaction { get; set; }

    public CreateUpdateMissionTransactionReturn() { }

  }

  public class CreateSendCharactersOnMissionTransactionReturn
  {
    [JsonProperty("createSendCharactersOnMissionTransaction")]
    public Transactions CreateSendCharactersOnMissionTransaction { get; set; }

    public CreateSendCharactersOnMissionTransactionReturn() { }

  }

  public class CreateRecallCharactersTransactionReturn
  {
    [JsonProperty("createRecallCharactersTransaction")]
    public Transactions CreateRecallCharactersTransaction { get; set; }

    public CreateRecallCharactersTransactionReturn() { }

  }

  public class FindResourcesReturn
  {
    [JsonProperty("resources")]
    public List<Resource> Resources { get; set; }

    public FindResourcesReturn() { }

  }

  public class FindResourcesBalanceReturn
  {
    [JsonProperty("resourcesBalance")]
    public List<ResourceBalance> ResourcesBalance { get; set; }

    public FindResourcesBalanceReturn() { }

  }

  public class FindFaucetsReturn
  {
    [JsonProperty("faucets")]
    public List<Faucet> Faucets { get; set; }

    public FindFaucetsReturn() { }

  }

  public class FindRecipesReturn
  {
    [JsonProperty("recipes")]
    public List<Recipe> Recipes { get; set; }

    public FindRecipesReturn() { }

  }

  public class FindHoldingsReturn
  {
    [JsonProperty("holdings")]
    public List<Holding> Holdings { get; set; }

    public FindHoldingsReturn() { }

  }

  public class CreateCreateNewResourceTransactionReturn
  {
    [JsonProperty("createCreateNewResourceTransaction")]
    public CreateInitResourceTransactionResponse CreateCreateNewResourceTransaction { get; set; }

    public CreateCreateNewResourceTransactionReturn() { }

  }

  public class CreateImportFungibleResourceTransactionReturn
  {
    [JsonProperty("createImportFungibleResourceTransaction")]
    public CreateInitResourceTransactionResponse CreateImportFungibleResourceTransaction { get; set; }

    public CreateImportFungibleResourceTransactionReturn() { }

  }

  public class CreateExportFungibleResourceTransactionReturn
  {
    [JsonProperty("createExportFungibleResourceTransaction")]
    public Transaction CreateExportFungibleResourceTransaction { get; set; }

    public CreateExportFungibleResourceTransactionReturn() { }

  }

  public class CreateCreateNewResourceTreeTransactionReturn
  {
    [JsonProperty("createCreateNewResourceTreeTransaction")]
    public TreeSetupResponse CreateCreateNewResourceTreeTransaction { get; set; }

    public CreateCreateNewResourceTreeTransactionReturn() { }

  }

  public class CreateMintResourceTransactionReturn
  {
    [JsonProperty("createMintResourceTransaction")]
    public Transaction CreateMintResourceTransaction { get; set; }

    public CreateMintResourceTransactionReturn() { }

  }

  public class CreateBurnResourceTransactionReturn
  {
    [JsonProperty("createBurnResourceTransaction")]
    public Transaction CreateBurnResourceTransaction { get; set; }

    public CreateBurnResourceTransactionReturn() { }

  }

  public class CreateTransferResourceTransactionReturn
  {
    [JsonProperty("createTransferResourceTransaction")]
    public Transaction CreateTransferResourceTransaction { get; set; }

    public CreateTransferResourceTransactionReturn() { }

  }

  public class CreateCreateWrapHoldingTransactionReturn
  {
    [JsonProperty("createCreateWrapHoldingTransaction")]
    public Transaction CreateCreateWrapHoldingTransaction { get; set; }

    public CreateCreateWrapHoldingTransactionReturn() { }

  }

  public class CreateCreateUnwrapHoldingTransactionReturn
  {
    [JsonProperty("createCreateUnwrapHoldingTransaction")]
    public Transaction CreateCreateUnwrapHoldingTransaction { get; set; }

    public CreateCreateUnwrapHoldingTransactionReturn() { }

  }

  public class CreateInitializeFaucetTransactionReturn
  {
    [JsonProperty("createInitializeFaucetTransaction")]
    public CreateInitializeFaucetTransactionResponse CreateInitializeFaucetTransaction { get; set; }

    public CreateInitializeFaucetTransactionReturn() { }

  }

  public class CreateClaimFaucetTransactionReturn
  {
    [JsonProperty("createClaimFaucetTransaction")]
    public Transaction CreateClaimFaucetTransaction { get; set; }

    public CreateClaimFaucetTransactionReturn() { }

  }

  public class CreateInitializeRecipeTransactionReturn
  {
    [JsonProperty("createInitializeRecipeTransaction")]
    public CreateInitializeRecipeTransactionResponse CreateInitializeRecipeTransaction { get; set; }

    public CreateInitializeRecipeTransactionReturn() { }

  }

  public class CreateAddIngredientsTransactionReturn
  {
    [JsonProperty("createAddIngredientsTransaction")]
    public Transactions CreateAddIngredientsTransaction { get; set; }

    public CreateAddIngredientsTransactionReturn() { }

  }

  public class CreateRemoveIngredientsTransactionReturn
  {
    [JsonProperty("createRemoveIngredientsTransaction")]
    public Transactions CreateRemoveIngredientsTransaction { get; set; }

    public CreateRemoveIngredientsTransactionReturn() { }

  }

  public class CreateInitCookingProcessTransactionsReturn
  {
    [JsonProperty("createInitCookingProcessTransactions")]
    public Transactions CreateInitCookingProcessTransactions { get; set; }

    public CreateInitCookingProcessTransactionsReturn() { }

  }

  public class CreateInitializeBadgeCriteriaTransactionReturn
  {
    [JsonProperty("createInitializeBadgeCriteriaTransaction")]
    public Transaction CreateInitializeBadgeCriteriaTransaction { get; set; }

    public CreateInitializeBadgeCriteriaTransactionReturn() { }

  }

  public class CreateClaimBadgeCriteriaTransactionReturn
  {
    [JsonProperty("createClaimBadgeCriteriaTransaction")]
    public Transaction CreateClaimBadgeCriteriaTransaction { get; set; }

    public CreateClaimBadgeCriteriaTransactionReturn() { }

  }

  public class CreateUpdateBadgeCriteriaTransactionReturn
  {
    [JsonProperty("createUpdateBadgeCriteriaTransaction")]
    public Transaction CreateUpdateBadgeCriteriaTransaction { get; set; }

    public CreateUpdateBadgeCriteriaTransactionReturn() { }

  }

}

