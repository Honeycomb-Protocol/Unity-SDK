using Newtonsoft.Json;
using System.Collections.Generic;

using HplEdgeClient.Enums;

namespace HplEdgeClient.Types {
  public class CharacterConfig
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("criterias")]
    public List<AssetCriteria> Criterias { get; set; }

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("creators")]
    public List<NftCreator> Creators { get; set; }

    [JsonProperty("sellerFeeBasisPoints")]
    public int SellerFeeBasisPoints { get; set; }

    [JsonProperty("collectionName")]
    public string CollectionName { get; set; }

    [JsonProperty("mintAs")]
    public MintAs MintAs { get; set; }

    public CharacterConfig () {} 

  }

  public class MintAsParams
  {
    [JsonProperty("merkleTree")]
    public string MerkleTree { get; set; }

    public MintAsParams () {} 

  }

  public class CharacterSourceParams
  {
    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("criteria")]
    public AssetCriteria Criteria { get; set; }

    [JsonProperty("kind")]
    public SourceKind Kind { get; set; }

    [JsonProperty("hash")]
    public string Hash { get; set; }

    [JsonProperty("uri")]
    public string Uri { get; set; }

    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    public CharacterSourceParams () {} 

  }

  public class CharacterUsedByParams
  {
    [JsonProperty("pool")]
    public string Pool { get; set; }

    [JsonProperty("staker")]
    public string Staker { get; set; }

    [JsonProperty("stakedAt")]
    public int StakedAt { get; set; }

    [JsonProperty("claimedAt")]
    public int ClaimedAt { get; set; }

    [JsonProperty("missionId")]
    public string MissionId { get; set; }

    [JsonProperty("participationId")]
    public string ParticipationId { get; set; }

    [JsonProperty("rewards")]
    public List<EarnedRewards> Rewards { get; set; }

    [JsonProperty("endTime")]
    public int EndTime { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("role")]
    public GuildRole Role { get; set; }

    [JsonProperty("order")]
    public int Order { get; set; }

    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("user")]
    public string User { get; set; }

    [JsonProperty("data")]
    public object Data { get; set; }

    public CharacterUsedByParams () {} 

  }

  public class ServiceParams
  {
    [JsonProperty("assemblerId")]
    public string AssemblerId { get; set; }

    [JsonProperty("assetManagerId")]
    public string AssetManagerId { get; set; }

    [JsonProperty("poolId")]
    public string PoolId { get; set; }

    [JsonProperty("kitId")]
    public string KitId { get; set; }

    public ServiceParams () {} 

  }

  public class MissionRequirement
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public TimeRequirementParams Params { get; set; }

    public MissionRequirement () {} 

  }

  public class RewardType
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public ResourceRewardTypeParams Params { get; set; }

    public RewardType () {} 

  }

  public class MultiplierTypeParams
  {
    [JsonProperty("minDuration")]
    public string MinDuration { get; set; }

    [JsonProperty("minCount")]
    public string MinCount { get; set; }

    [JsonProperty("creator")]
    public string Creator { get; set; }

    [JsonProperty("collection")]
    public string Collection { get; set; }

    public MultiplierTypeParams () {} 

  }

  public class OutputHolding
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("tree_id")]
    public string Tree_id { get; set; }

    [JsonProperty("leaf_idx")]
    public string Leaf_idx { get; set; }

    [JsonProperty("holder")]
    public string Holder { get; set; }

    [JsonProperty("balance")]
    public string Balance { get; set; }

    [JsonProperty("characteristics")]
    public object Characteristics { get; set; }

    [JsonProperty("proof")]
    public Proof Proof { get; set; }

    [JsonProperty("tree")]
    public string Tree { get; set; }

    public OutputHolding () {} 

  }

  public class ResourceKindParams
  {
    [JsonProperty("decimals")]
    public int Decimals { get; set; }

    [JsonProperty("custody")]
    public ResourceCustody Custody { get; set; }

    [JsonProperty("characteristics")]
    public List<string> Characteristics { get; set; }

    public ResourceKindParams () {} 

  }

  public class CharacterHistory
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("event")]
    public string Event { get; set; }

    [JsonProperty("event_data")]
    public object Event_data { get; set; }

    [JsonProperty("time")]
    public string Time { get; set; }

    public CharacterHistory () {} 

  }

  public class AssemblerConfig
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("program_id")]
    public string Program_id { get; set; }

    [JsonProperty("discriminator")]
    public string Discriminator { get; set; }

    [JsonProperty("ticker")]
    public string Ticker { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("order")]
    public List<string> Order { get; set; }

    [JsonProperty("merkle_trees")]
    public ControlledMerkleTrees Merkle_trees { get; set; }

    public AssemblerConfig () {} 

  }

  public class CharacterTrait
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("tree_id")]
    public string Tree_id { get; set; }

    [JsonProperty("leaf_idx")]
    public string Leaf_idx { get; set; }

    [JsonProperty("label")]
    public string Label { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("uri")]
    public string Uri { get; set; }

    [JsonProperty("proof")]
    public Proof Proof { get; set; }

    public CharacterTrait () {} 

  }

  public class CharacterModel
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("program_id")]
    public string Program_id { get; set; }

    [JsonProperty("discriminator")]
    public string Discriminator { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("config")]
    public CharacterConfig Config { get; set; }

    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("merkle_trees")]
    public ControlledMerkleTrees Merkle_trees { get; set; }

    public CharacterModel () {} 

  }

  public class CharacterConfigWrapped
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("criterias")]
    public List<AssetCriteria> Criterias { get; set; }

    public CharacterConfigWrapped () {} 

  }

  public class CharacterConfigAssembled
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("creators")]
    public List<NftCreator> Creators { get; set; }

    [JsonProperty("sellerFeeBasisPoints")]
    public int SellerFeeBasisPoints { get; set; }

    [JsonProperty("collectionName")]
    public string CollectionName { get; set; }

    [JsonProperty("mintAs")]
    public MintAs MintAs { get; set; }

    public CharacterConfigAssembled () {} 

  }

  public class NftCreator
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("share")]
    public int Share { get; set; }

    public NftCreator () {} 

  }

  public class MintAs
  {
    [JsonProperty("kind")]
    public MintAsKind Kind { get; set; }

    [JsonProperty("params")]
    public MintAsParams Params { get; set; }

    public MintAs () {} 

  }

  public class MintAsParamsMplBubblegum
  {
    [JsonProperty("merkleTree")]
    public string MerkleTree { get; set; }

    public MintAsParamsMplBubblegum () {} 

  }

  public class Character
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("tree_id")]
    public string Tree_id { get; set; }

    [JsonProperty("leaf_idx")]
    public string Leaf_idx { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("source")]
    public CharacterSource Source { get; set; }

    [JsonProperty("usedBy")]
    public CharacterUsedBy UsedBy { get; set; }

    [JsonProperty("proof")]
    public Proof Proof { get; set; }

    [JsonProperty("asset")]
    public object Asset { get; set; }

    public Character () {} 

  }

  public class CharacterSource
  {
    [JsonProperty("kind")]
    public CharacterSourceKind Kind { get; set; }

    [JsonProperty("params")]
    public CharacterSourceParams Params { get; set; }

    public CharacterSource () {} 

  }

  public class Wrapped
  {
    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("criteria")]
    public AssetCriteria Criteria { get; set; }

    [JsonProperty("kind")]
    public SourceKind Kind { get; set; }

    public Wrapped () {} 

  }

  public class AssetCriteria
  {
    [JsonProperty("kind")]
    public AssetCriteriaKind Kind { get; set; }

    [JsonProperty("params")]
    public string Params { get; set; }

    public AssetCriteria () {} 

  }

  public class Assembled
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }

    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("uri")]
    public string Uri { get; set; }

    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    public Assembled () {} 

  }

  public class CharacterUsedBy
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public CharacterUsedByParams Params { get; set; }

    public CharacterUsedBy () {} 

  }

  public class UsedByStaking
  {
    [JsonProperty("pool")]
    public string Pool { get; set; }

    [JsonProperty("staker")]
    public string Staker { get; set; }

    [JsonProperty("stakedAt")]
    public int StakedAt { get; set; }

    [JsonProperty("claimedAt")]
    public int ClaimedAt { get; set; }

    public UsedByStaking () {} 

  }

  public class UsedByMission
  {
    [JsonProperty("missionId")]
    public string MissionId { get; set; }

    [JsonProperty("participationId")]
    public string ParticipationId { get; set; }

    [JsonProperty("rewards")]
    public List<EarnedRewards> Rewards { get; set; }

    [JsonProperty("endTime")]
    public int EndTime { get; set; }

    public UsedByMission () {} 

  }

  public class EarnedRewards
  {
    [JsonProperty("delta")]
    public int Delta { get; set; }

    [JsonProperty("rewardIdx")]
    public int RewardIdx { get; set; }

    [JsonProperty("collected")]
    public bool Collected { get; set; }

    public EarnedRewards () {} 

  }

  public class UsedByGuild
  {
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("role")]
    public GuildRole Role { get; set; }

    [JsonProperty("order")]
    public int Order { get; set; }

    public UsedByGuild () {} 

  }

  public class GuildRole
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    public GuildRole () {} 

  }

  public class UsedByEjected
  {
    [JsonProperty("mint")]
    public string Mint { get; set; }

    public UsedByEjected () {} 

  }

  public class UsedByCustom
  {
    [JsonProperty("user")]
    public string User { get; set; }

    [JsonProperty("data")]
    public object Data { get; set; }

    public UsedByCustom () {} 

  }

  public class Global
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("config")]
    public object Config { get; set; }

    [JsonProperty("userTrees")]
    public ControlledMerkleTrees UserTrees { get; set; }

    [JsonProperty("totalUsers")]
    public int TotalUsers { get; set; }

    public Global () {} 

  }

  public class Project
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("driver")]
    public string Driver { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("services")]
    public List<Service> Services { get; set; }

    [JsonProperty("associatedPrograms")]
    public List<AssociatedProgram> AssociatedPrograms { get; set; }

    [JsonProperty("profileDataConfig")]
    public ProfileDataConfig ProfileDataConfig { get; set; }

    [JsonProperty("profileTrees")]
    public ControlledMerkleTrees ProfileTrees { get; set; }

    [JsonProperty("badgeCriteria")]
    public List<BadgeCriteria> BadgeCriteria { get; set; }

    [JsonProperty("subsidyFees")]
    public bool SubsidyFees { get; set; }

    public Project () {} 

  }

  public class DelegateAuthority
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegations")]
    public List<ServiceDelegation> Delegations { get; set; }

    public DelegateAuthority () {} 

  }

  public class ServiceDelegation
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("index")]
    public int? Index { get; set; }

    [JsonProperty("permission")]
    public string Permission { get; set; }

    public ServiceDelegation () {} 

  }

  public class Service
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public ServiceParams Params { get; set; }

    public Service () {} 

  }

  public class ServiceParamsAssembler
  {
    [JsonProperty("assemblerId")]
    public string AssemblerId { get; set; }

    public ServiceParamsAssembler () {} 

  }

  public class ServiceParamsAssetManager
  {
    [JsonProperty("assetManagerId")]
    public string AssetManagerId { get; set; }

    public ServiceParamsAssetManager () {} 

  }

  public class ServiceParamsStaking
  {
    [JsonProperty("poolId")]
    public string PoolId { get; set; }

    public ServiceParamsStaking () {} 

  }

  public class ServiceParamsMissions
  {
    [JsonProperty("poolId")]
    public string PoolId { get; set; }

    public ServiceParamsMissions () {} 

  }

  public class ServiceParamsRaffles
  {
    [JsonProperty("poolId")]
    public string PoolId { get; set; }

    public ServiceParamsRaffles () {} 

  }

  public class ServiceParamsGuildKit
  {
    [JsonProperty("kitId")]
    public string KitId { get; set; }

    public ServiceParamsGuildKit () {} 

  }

  public class AssociatedProgram
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("trustedActions")]
    public List<SerializableActions> TrustedActions { get; set; }

    public AssociatedProgram () {} 

  }

  public class SerializableActions
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    public SerializableActions () {} 

  }

  public class ProfileDataConfig
  {
    [JsonProperty("achievements")]
    public List<string> Achievements { get; set; }

    [JsonProperty("customDataFields")]
    public List<string> CustomDataFields { get; set; }

    public ProfileDataConfig () {} 

  }

  public class User
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("tree_id")]
    public string Tree_id { get; set; }

    [JsonProperty("leaf_idx")]
    public string Leaf_idx { get; set; }

    [JsonProperty("proof")]
    public Proof Proof { get; set; }

    [JsonProperty("info")]
    public UserInfo Info { get; set; }

    [JsonProperty("socialInfo")]
    public SocialInfo SocialInfo { get; set; }

    [JsonProperty("wallets")]
    public Wallets Wallets { get; set; }

    [JsonProperty("profiles")]
    public List<Profile> Profiles { get; set; }

    public User () {} 

  }

  public class UserInfo
  {
    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("bio")]
    public string Bio { get; set; }

    [JsonProperty("pfp")]
    public string Pfp { get; set; }

    public UserInfo () {} 

  }

  public class CivicInfo
  {
    [JsonProperty("gatekeeperNetwork")]
    public CivicGateway GatekeeperNetwork { get; set; }

    [JsonProperty("expiry")]
    public string Expiry { get; set; }

    [JsonProperty("walletIndex")]
    public int WalletIndex { get; set; }

    public CivicInfo () {} 

  }

  public class SocialInfo
  {
    [JsonProperty("twitter")]
    public string Twitter { get; set; }

    [JsonProperty("discord")]
    public string Discord { get; set; }

    [JsonProperty("steam")]
    public string Steam { get; set; }

    [JsonProperty("civic")]
    public List<CivicInfo> Civic { get; set; }

    public SocialInfo () {} 

  }

  public class Wallets
  {
    [JsonProperty("shadow")]
    public string Shadow { get; set; }

    [JsonProperty("wallets")]
    public List<string> Wallets_ { get; set; }

    public Wallets () {} 

  }

  public class Profile
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("tree_id")]
    public string Tree_id { get; set; }

    [JsonProperty("leaf_idx")]
    public string Leaf_idx { get; set; }

    [JsonProperty("proof")]
    public Proof Proof { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("userId")]
    public int UserId { get; set; }

    [JsonProperty("identity")]
    public string Identity { get; set; }

    [JsonProperty("info")]
    public ProfileInfo Info { get; set; }

    [JsonProperty("platformData")]
    public PlatformData PlatformData { get; set; }

    [JsonProperty("customData")]
    public object CustomData { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    public Profile () {} 

  }

  public class ProfileInfo
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("bio")]
    public string Bio { get; set; }

    [JsonProperty("pfp")]
    public string Pfp { get; set; }

    public ProfileInfo () {} 

  }

  public class PlatformData
  {
    [JsonProperty("custom")]
    public object Custom { get; set; }

    [JsonProperty("xp")]
    public int Xp { get; set; }

    [JsonProperty("achievements")]
    public List<int> Achievements { get; set; }

    public PlatformData () {} 

  }

  public class BadgeCriteria
  {
    [JsonProperty("startTime")]
    public string StartTime { get; set; }

    [JsonProperty("endTime")]
    public string EndTime { get; set; }

    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("condition")]
    public BadgesCondition Condition { get; set; }

    public BadgeCriteria () {} 

  }

  public class Account
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("program_id")]
    public string Program_id { get; set; }

    [JsonProperty("discriminator")]
    public string Discriminator { get; set; }

    [JsonProperty("parsed_data")]
    public object Parsed_data { get; set; }

    public Account () {} 

  }

  public class CompressedAccount
  {
    [JsonProperty("tree_id")]
    public string Tree_id { get; set; }

    [JsonProperty("leaf_idx")]
    public string Leaf_idx { get; set; }

    [JsonProperty("schema_validated")]
    public bool? Schema_validated { get; set; }

    [JsonProperty("raw_data")]
    public string Raw_data { get; set; }

    [JsonProperty("parsed_data")]
    public object Parsed_data { get; set; }

    public CompressedAccount () {} 

  }

  public class Node
  {
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("tree")]
    public string Tree { get; set; }

    [JsonProperty("node_idx")]
    public string Node_idx { get; set; }

    [JsonProperty("leaf_idx")]
    public string Leaf_idx { get; set; }

    [JsonProperty("seq")]
    public string Seq { get; set; }

    [JsonProperty("level")]
    public string Level { get; set; }

    [JsonProperty("hash")]
    public string Hash { get; set; }

    public Node () {} 

  }

  public class Proof
  {
    [JsonProperty("root")]
    public string Root { get; set; }

    [JsonProperty("proof")]
    public List<string> Proof_ { get; set; }

    [JsonProperty("node_index")]
    public string Node_index { get; set; }

    [JsonProperty("leaf")]
    public string Leaf { get; set; }

    [JsonProperty("maxDepth")]
    public int MaxDepth { get; set; }

    [JsonProperty("leaf_index")]
    public string Leaf_index { get; set; }

    [JsonProperty("tree_id")]
    public string Tree_id { get; set; }

    [JsonProperty("canopy_depth")]
    public int Canopy_depth { get; set; }

    public Proof () {} 

  }

  public class ControlledMerkleTrees
  {
    [JsonProperty("active")]
    public int Active { get; set; }

    [JsonProperty("schema")]
    public object Schema { get; set; }

    [JsonProperty("merkle_trees")]
    public List<string> Merkle_trees { get; set; }

    public ControlledMerkleTrees () {} 

  }

  public class MissionPool
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("program_id")]
    public string Program_id { get; set; }

    [JsonProperty("discriminator")]
    public string Discriminator { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("factionsMerkleRoot")]
    public string FactionsMerkleRoot { get; set; }

    [JsonProperty("randomizerRound")]
    public int RandomizerRound { get; set; }

    [JsonProperty("characterModels")]
    public List<string> CharacterModels { get; set; }

    [JsonProperty("guildKits")]
    public List<int> GuildKits { get; set; }

    public MissionPool () {} 

  }

  public class Mission
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("program_id")]
    public string Program_id { get; set; }

    [JsonProperty("discriminator")]
    public string Discriminator { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("missionPool")]
    public string MissionPool { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("minXp")]
    public string MinXp { get; set; }

    [JsonProperty("cost")]
    public MissionCost Cost { get; set; }

    [JsonProperty("requirement")]
    public MissionRequirement Requirement { get; set; }

    [JsonProperty("rewards")]
    public List<Reward> Rewards { get; set; }

    public Mission () {} 

  }

  public class MissionCost
  {
    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("resource_address")]
    public string Resource_address { get; set; }

    public MissionCost () {} 

  }

  public class TimeRequirement
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public TimeRequirementParams Params { get; set; }

    public TimeRequirement () {} 

  }

  public class TimeRequirementParams
  {
    [JsonProperty("duration")]
    public string Duration { get; set; }

    public TimeRequirementParams () {} 

  }

  public class Reward
  {
    [JsonProperty("min")]
    public string Min { get; set; }

    [JsonProperty("max")]
    public string Max { get; set; }

    [JsonProperty("rewardType")]
    public RewardType RewardType { get; set; }

    public Reward () {} 

  }

  public class XpRewardType
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    public XpRewardType () {} 

  }

  public class ResourceRewardType
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public ResourceRewardTypeParams Params { get; set; }

    public ResourceRewardType () {} 

  }

  public class ResourceRewardTypeParams
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    public ResourceRewardTypeParams () {} 

  }

  public class StakingPool
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("lockType")]
    public LockType LockType { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("rewardsPerDuration")]
    public string RewardsPerDuration { get; set; }

    [JsonProperty("rewardsDuration")]
    public string RewardsDuration { get; set; }

    [JsonProperty("maxRewardsDuration")]
    public string MaxRewardsDuration { get; set; }

    [JsonProperty("minStakeDuration")]
    public string MinStakeDuration { get; set; }

    [JsonProperty("cooldownDuration")]
    public string CooldownDuration { get; set; }

    [JsonProperty("resetStakeDuration")]
    public bool ResetStakeDuration { get; set; }

    [JsonProperty("allowedMints")]
    public bool AllowedMints { get; set; }

    [JsonProperty("totalStaked")]
    public string TotalStaked { get; set; }

    [JsonProperty("startTime")]
    public string StartTime { get; set; }

    [JsonProperty("endTime")]
    public string EndTime { get; set; }

    [JsonProperty("characterModels")]
    public List<string> CharacterModels { get; set; }

    public StakingPool () {} 

  }

  public class LockType
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    public LockType () {} 

  }

  public class Multipliers
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("stakingPool")]
    public string StakingPool { get; set; }

    [JsonProperty("decimals")]
    public int Decimals { get; set; }

    [JsonProperty("durationMultipliers")]
    public List<Multiplier> DurationMultipliers { get; set; }

    [JsonProperty("countMultipliers")]
    public List<Multiplier> CountMultipliers { get; set; }

    [JsonProperty("creatorMultipliers")]
    public List<Multiplier> CreatorMultipliers { get; set; }

    [JsonProperty("collectionMultipliers")]
    public List<Multiplier> CollectionMultipliers { get; set; }

    public Multipliers () {} 

  }

  public class Multiplier
  {
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("multiplierType")]
    public MultiplierType MultiplierType { get; set; }

    public Multiplier () {} 

  }

  public class MultiplierType
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public MultiplierTypeParams Params { get; set; }

    public MultiplierType () {} 

  }

  public class MultiplierTypeParamsStakeDuration
  {
    [JsonProperty("minDuration")]
    public string MinDuration { get; set; }

    public MultiplierTypeParamsStakeDuration () {} 

  }

  public class MultiplierTypeParamsNFTCount
  {
    [JsonProperty("minCount")]
    public string MinCount { get; set; }

    public MultiplierTypeParamsNFTCount () {} 

  }

  public class MultiplierTypeParamsCreator
  {
    [JsonProperty("creator")]
    public string Creator { get; set; }

    public MultiplierTypeParamsCreator () {} 

  }

  public class MultiplierTypeParamsCollection
  {
    [JsonProperty("collection")]
    public string Collection { get; set; }

    public MultiplierTypeParamsCollection () {} 

  }

  public class Staker
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("stakingPool")]
    public string StakingPool { get; set; }

    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    [JsonProperty("totalStaked")]
    public string TotalStaked { get; set; }

    public Staker () {} 

  }

  public class Transaction
  {
    [JsonProperty("transaction")]
    public string Transaction_ { get; set; }

    [JsonProperty("blockhash")]
    public string Blockhash { get; set; }

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight { get; set; }

    public Transaction () {} 

  }

  public class CreateCreateProjectTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    public CreateCreateProjectTransactionResponse () {} 

  }

  public class CreateAssemblerConfigTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("treeAddress")]
    public string TreeAddress { get; set; }

    [JsonProperty("proofBytes")]
    public int ProofBytes { get; set; }

    [JsonProperty("space")]
    public int Space { get; set; }

    [JsonProperty("cost")]
    public float? Cost { get; set; }

    [JsonProperty("maxTreeCapacity")]
    public int MaxTreeCapacity { get; set; }

    public CreateAssemblerConfigTransactionResponse () {} 

  }

  public class CreateCharacterModelTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    public CreateCharacterModelTransactionResponse () {} 

  }

  public class CreateInitResourceTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    public CreateInitResourceTransactionResponse () {} 

  }

  public class CreateCreateNewResourceTreeTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("tree")]
    public string Tree { get; set; }

    public CreateCreateNewResourceTreeTransactionResponse () {} 

  }

  public class CreateInitializeRecipeTransactionResponse
  {
    [JsonProperty("transactions")]
    public Transactions Transactions { get; set; }

    [JsonProperty("recipe")]
    public string Recipe { get; set; }

    public CreateInitializeRecipeTransactionResponse () {} 

  }

  public class CreateBeginCookingTransactionResponse
  {
    [JsonProperty("transaction")]
    public Transaction Transaction { get; set; }

    [JsonProperty("cooking")]
    public string Cooking { get; set; }

    public CreateBeginCookingTransactionResponse () {} 

  }

  public class Transactions
  {
    [JsonProperty("transactions")]
    public List<string> Transactions_ { get; set; }

    [JsonProperty("blockhash")]
    public string Blockhash { get; set; }

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight { get; set; }

    public Transactions () {} 

  }

  public class TransactionResponse
  {
    [JsonProperty("signature")]
    public string Signature { get; set; }

    [JsonProperty("error")]
    public object Error { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    public TransactionResponse () {} 

  }

  public class TransactionBundleResponse
  {
    [JsonProperty("bundleId")]
    public int BundleId { get; set; }

    [JsonProperty("responses")]
    public List<TransactionResponse> Responses { get; set; }

    public TransactionBundleResponse () {} 

  }

  public class AuthResponse
  {
    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("tx")]
    public string Tx { get; set; }

    public AuthResponse () {} 

  }

  public class AuthConfirmed
  {
    [JsonProperty("accessToken")]
    public string AccessToken { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    public AuthConfirmed () {} 

  }

  public class OutputHoldingTree
  {
    [JsonProperty("tree")]
    public string Tree { get; set; }

    public OutputHoldingTree () {} 

  }

  public class CreateCreateHolderAccountTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("holderAccount")]
    public string HolderAccount { get; set; }

    public CreateCreateHolderAccountTransactionResponse () {} 

  }

  public class CreateInitMultipliersTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("multipliersAddress")]
    public string MultipliersAddress { get; set; }

    public CreateInitMultipliersTransactionResponse () {} 

  }

  public class CreateCreateStakingPoolTransactionResponse
  {
    [JsonProperty("transactions")]
    public Transactions Transactions { get; set; }

    [JsonProperty("stakingPoolAddress")]
    public string StakingPoolAddress { get; set; }

    [JsonProperty("multipliersAddress")]
    public string MultipliersAddress { get; set; }

    public CreateCreateStakingPoolTransactionResponse () {} 

  }

  public class CreateCreateMissionPoolTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("missionPoolAddress")]
    public string MissionPoolAddress { get; set; }

    public CreateCreateMissionPoolTransactionResponse () {} 

  }

  public class CreateUpdateMissionPoolTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    public CreateUpdateMissionPoolTransactionResponse () {} 

  }

  public class CreateCreateMissionTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("missionAddress")]
    public string MissionAddress { get; set; }

    public CreateCreateMissionTransactionResponse () {} 

  }

  public class CreateUpdateMissionTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    public CreateUpdateMissionTransactionResponse () {} 

  }

  public class CreateInitializeFaucetTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("faucet")]
    public string Faucet { get; set; }

    public CreateInitializeFaucetTransactionResponse () {} 

  }

  public class TreeSetupResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx { get; set; }

    [JsonProperty("treeAddress")]
    public string TreeAddress { get; set; }

    [JsonProperty("proofBytes")]
    public int ProofBytes { get; set; }

    [JsonProperty("space")]
    public int Space { get; set; }

    [JsonProperty("cost")]
    public float? Cost { get; set; }

    [JsonProperty("maxTreeCapacity")]
    public int MaxTreeCapacity { get; set; }

    public TreeSetupResponse () {} 

  }

  public class Resource
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("storage")]
    public ResourceStorage Storage { get; set; }

    [JsonProperty("kind")]
    public ResourceKind Kind { get; set; }

    public Resource () {} 

  }

  public class ResourceBalance
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    [JsonProperty("resourceStorage")]
    public ResourceStorageEnum ResourceStorage { get; set; }

    public ResourceBalance () {} 

  }

  public class ResourceStorage
  {
    [JsonProperty("kind")]
    public ResourceStorageEnum Kind { get; set; }

    [JsonProperty("params")]
    public ResourceStorageParams Params { get; set; }

    public ResourceStorage () {} 

  }

  public class ResourceStorageParams
  {
    [JsonProperty("merkle_trees")]
    public ControlledMerkleTrees Merkle_trees { get; set; }

    [JsonProperty("promiseSupply")]
    public string PromiseSupply { get; set; }

    public ResourceStorageParams () {} 

  }

  public class ResourceKind
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public ResourceKindParams Params { get; set; }

    public ResourceKind () {} 

  }

  public class ResourceKindParamsHplFungible
  {
    [JsonProperty("decimals")]
    public int Decimals { get; set; }

    public ResourceKindParamsHplFungible () {} 

  }

  public class ResourceKindParamsWrappedFungible
  {
    [JsonProperty("decimals")]
    public int Decimals { get; set; }

    [JsonProperty("custody")]
    public ResourceCustody Custody { get; set; }

    public ResourceKindParamsWrappedFungible () {} 

  }

  public class ResourceCustody
  {
    [JsonProperty("kind")]
    public ResourceCustodyEnum Kind { get; set; }

    [JsonProperty("params")]
    public ResourceCustodyParams Params { get; set; }

    public ResourceCustody () {} 

  }

  public class ResourceCustodyParams
  {
    [JsonProperty("burnerDestination")]
    public string BurnerDestination { get; set; }

    public ResourceCustodyParams () {} 

  }

  public class ResourceKindParamsHplNonFungible
  {
    [JsonProperty("characteristics")]
    public List<string> Characteristics { get; set; }

    public ResourceKindParamsHplNonFungible () {} 

  }

  public class ResourceKindParamsWrappedMplCore
  {
    [JsonProperty("characteristics")]
    public List<string> Characteristics { get; set; }

    public ResourceKindParamsWrappedMplCore () {} 

  }

  public class Recipe
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("bump")]
    public int Bump { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("xp")]
    public string Xp { get; set; }

    [JsonProperty("ingredients")]
    public List<Ingredient> Ingredients { get; set; }

    [JsonProperty("meal")]
    public Meal Meal { get; set; }

    public Recipe () {} 

  }

  public class Ingredient
  {
    [JsonProperty("resourceAddress")]
    public string ResourceAddress { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    public Ingredient () {} 

  }

  public class Meal
  {
    [JsonProperty("resourceAddress")]
    public string ResourceAddress { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    public Meal () {} 

  }

  public class Faucet
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("repeatInterval")]
    public string RepeatInterval { get; set; }

    [JsonProperty("lastClaimed")]
    public string LastClaimed { get; set; }

    public Faucet () {} 

  }

  public class Holding
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("tree_id")]
    public string Tree_id { get; set; }

    [JsonProperty("leaf_idx")]
    public string Leaf_idx { get; set; }

    [JsonProperty("holder")]
    public string Holder { get; set; }

    [JsonProperty("balance")]
    public string Balance { get; set; }

    [JsonProperty("characteristics")]
    public object Characteristics { get; set; }

    [JsonProperty("proof")]
    public Proof Proof { get; set; }

    public Holding () {} 

  }

}

